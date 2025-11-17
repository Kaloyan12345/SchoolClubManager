using System.Text.Json;
using Microsoft.Data.Sqlite;
using SchoolClubManager.Business.Models;

namespace SchoolClubManager.Data.Repositories;

public class SqliteProjectRepository : IProjectRepository
{
    private readonly string _connectionString;
    private readonly JsonSerializerOptions _jsonOptions = new()
    {
        WriteIndented = false,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    public SqliteProjectRepository(string databasePath)
    {
        var folder = Path.GetDirectoryName(databasePath);
        if (!string.IsNullOrEmpty(folder))
        {
            Directory.CreateDirectory(folder);
        }
        _connectionString = $"Data Source={databasePath}";
        Initialize();
    }

    private void Initialize()
    {
        using var connection = new SqliteConnection(_connectionString);
        connection.Open();
        var command = connection.CreateCommand();
        command.CommandText =
            """
            CREATE TABLE IF NOT EXISTS Projects (
                Id TEXT PRIMARY KEY,
                Title TEXT NOT NULL,
                Theme TEXT NOT NULL,
                MeetingDay INTEGER NOT NULL,
                MentorJson TEXT NOT NULL,
                StudentLeadJson TEXT NOT NULL,
                TeamJson TEXT NOT NULL,
                TasksJson TEXT NOT NULL,
                Status INTEGER NOT NULL,
                Notes TEXT
            );
            """;
        command.ExecuteNonQuery();
    }

    public List<ClubProject> GetAll()
    {
        using var connection = new SqliteConnection(_connectionString);
        connection.Open();

        var projects = new List<ClubProject>();
        var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Projects ORDER BY Title COLLATE NOCASE";

        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            projects.Add(Map(reader));
        }

        return projects;
    }

    public ClubProject? GetById(Guid id)
    {
        using var connection = new SqliteConnection(_connectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Projects WHERE Id = $id";
        command.Parameters.AddWithValue("$id", id.ToString());

        using var reader = command.ExecuteReader();
        return reader.Read() ? Map(reader) : null;
    }

    public void Add(ClubProject project)
    {
        using var connection = new SqliteConnection(_connectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText =
            """
            INSERT INTO Projects
            (Id, Title, Theme, MeetingDay, MentorJson, StudentLeadJson, TeamJson, TasksJson, Status, Notes)
            VALUES
            ($id, $title, $theme, $meetingDay, $mentor, $studentLead, $team, $tasks, $status, $notes)
            """;

        FillParameters(command, project);
        command.ExecuteNonQuery();
    }

    public void Update(ClubProject project)
    {
        using var connection = new SqliteConnection(_connectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText =
            """
            UPDATE Projects SET
                Title = $title,
                Theme = $theme,
                MeetingDay = $meetingDay,
                MentorJson = $mentor,
                StudentLeadJson = $studentLead,
                TeamJson = $team,
                TasksJson = $tasks,
                Status = $status,
                Notes = $notes
            WHERE Id = $id
            """;

        FillParameters(command, project);
        command.ExecuteNonQuery();
    }

    public void Delete(Guid id)
    {
        using var connection = new SqliteConnection(_connectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "DELETE FROM Projects WHERE Id = $id";
        command.Parameters.AddWithValue("$id", id.ToString());
        command.ExecuteNonQuery();
    }

    private void FillParameters(SqliteCommand command, ClubProject project)
    {
        command.Parameters.AddWithValue("$id", project.Id.ToString());
        command.Parameters.AddWithValue("$title", project.Title);
        command.Parameters.AddWithValue("$theme", project.Theme);
        command.Parameters.AddWithValue("$meetingDay", (int)project.MeetingDay);
        command.Parameters.AddWithValue("$mentor", Serialize(project.Mentor));
        command.Parameters.AddWithValue("$studentLead", Serialize(project.StudentLead));
        command.Parameters.AddWithValue("$team", Serialize(project.Team));
        command.Parameters.AddWithValue("$tasks", Serialize(project.Tasks));
        command.Parameters.AddWithValue("$status", (int)project.Status);
        command.Parameters.AddWithValue("$notes", project.Notes ?? string.Empty);
    }

    private ClubProject Map(SqliteDataReader reader)
    {
        return new ClubProject
        {
            Id = Guid.Parse(reader.GetString(0)),
            Title = reader.GetString(1),
            Theme = reader.GetString(2),
            MeetingDay = (DayOfWeek)reader.GetInt32(3),
            Mentor = Deserialize<Mentor>(reader.GetString(4)),
            StudentLead = Deserialize<Student>(reader.GetString(5)),
            Team = Deserialize<ClubTeam>(reader.GetString(6)),
            Tasks = Deserialize<List<TaskItem>>(reader.GetString(7)),
            Status = (ProjectStatus)reader.GetInt32(8),
            Notes = reader.IsDBNull(9) ? string.Empty : reader.GetString(9)
        };
    }

    private string Serialize<T>(T value) =>
        JsonSerializer.Serialize(value, _jsonOptions);

    private T Deserialize<T>(string json) =>
        JsonSerializer.Deserialize<T>(json, _jsonOptions)!;
}

