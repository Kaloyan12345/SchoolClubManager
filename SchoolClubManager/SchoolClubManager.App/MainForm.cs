using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SchoolClubManager.Business.Models;
using SchoolClubManager.Services.Contracts;

namespace SchoolClubManager.App
{
    public partial class MainForm : Form
    {
        private readonly IProjectService _projectService;
        private ClubProject? _selectedProject;

        public MainForm(IProjectService projectService)
        {
            _projectService = projectService;
            InitializeComponent();
            dayComboBox.DataSource = Enum.GetValues(typeof(DayOfWeek));
            statusComboBox.DataSource = Enum.GetValues(typeof(ProjectStatus));

            newTaskTextBox.KeyDown += NewTaskTextBox_KeyDown;
        }

        private void NewTaskTextBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                AddTaskButton_Click(sender!, EventArgs.Empty);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshProjects();
        }

        private void RefreshProjects()
        {
            var projects = _projectService.GetAll();

            projectsListBox.DataSource = null;
            projectsListBox.DataSource = projects.ToList();
            projectsListBox.DisplayMember = nameof(ClubProject.Title);

            summaryLabel.Text = projects.Count == 0
                ? "Няма създадени идеи."
                : $"Общо идеи: {projects.Count}";
        }

        private void projectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedProject = projectsListBox.SelectedItem as ClubProject;

            if (_selectedProject is null)
            {
                ClearEditor();
                return;
            }

            FillEditor(_selectedProject);
            detailsLabel.Text = BuildDetails(_selectedProject);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!TryBuildProject(null, out var project))
            {
                return;
            }

            var created = _projectService.Create(project);

            _selectedProject = created;
            RefreshProjects();
            projectsListBox.SelectedItem = created;
            detailsLabel.Text = BuildDetails(created);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (_selectedProject is null)
            {
                MessageBox.Show("Първо маркирай проект от списъка.");
                return;
            }

            if (!TryBuildProject(_selectedProject, out var updated))
            {
                return;
            }

            _projectService.Update(updated);

            RefreshProjects();
            projectsListBox.SelectedItem = updated;
            detailsLabel.Text = BuildDetails(updated);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (_selectedProject is null)
            {
                MessageBox.Show("Нищо не е избрано за изтриване.");
                return;
            }

            _projectService.Delete(_selectedProject.Id);

            _selectedProject = null;
            RefreshProjects();
            ClearEditor();
        }

        private bool TryBuildProject(ClubProject? baseProject, out ClubProject project)
        {
            project = baseProject ?? new ClubProject();

            var title = titleTextBox.Text.Trim();
            var theme = themeTextBox.Text.Trim();
            var mentorName = mentorTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(theme))
            {
                MessageBox.Show("Въведи име и тема на проекта.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(mentorName))
            {
                MessageBox.Show("Въведи име на ментор.");
                return false;
            }

            project.Title = title;
            project.Theme = theme;

            // Mentor
            project.Mentor.FullName = mentorName;
            project.Mentor.Email = mentorEmailTextBox.Text.Trim();
            project.Mentor.Role = mentorRoleTextBox.Text.Trim();

            // Meeting / Status
            project.MeetingDay = (DayOfWeek)dayComboBox.SelectedItem!;
            project.Status = (ProjectStatus)statusComboBox.SelectedItem!;

            // Notes
            project.Notes = notesTextBox.Text.Trim();

            // Team
            project.Team.Name = teamNameTextBox.Text.Trim();
            project.Team.Motto = teamMottoTextBox.Text.Trim();
            project.Team.Members = ParseMembers(teamMembersTextBox.Text);

            // Student lead
            var studentNames = studentLeadTextBox.Text
                .Trim()
                .Split(' ', 2, StringSplitOptions.RemoveEmptyEntries);

            project.StudentLead.FirstName = studentNames.Length > 0 ? studentNames[0] : "Лидер";
            project.StudentLead.LastName = studentNames.Length > 1 ? studentNames[1] : string.Empty;
            project.StudentLead.Grade = (int)studentGradeNumeric.Value;
            project.StudentLead.FavoriteSubject = studentSubjectTextBox.Text.Trim();

            // Tasks
            var tasks = new List<TaskItem>();
            for (int i = 0; i < tasksCheckedListBox.Items.Count; i++)
            {
                var description = tasksCheckedListBox.Items[i]?.ToString() ?? string.Empty;
                if (string.IsNullOrWhiteSpace(description)) continue;

                tasks.Add(new TaskItem
                {
                    Description = description.Trim(),
                    EstimatedHours = 1,
                    IsCompleted = tasksCheckedListBox.GetItemChecked(i)
                });
            }

            project.Tasks = tasks;

            return true;
        }

        private void ClearEditor()
        {
            titleTextBox.Clear();
            themeTextBox.Clear();
            mentorTextBox.Clear();
            mentorEmailTextBox.Clear();
            mentorRoleTextBox.Clear();

            dayComboBox.SelectedIndex = 0;
            statusComboBox.SelectedIndex = 0;

            notesTextBox.Clear();

            teamNameTextBox.Clear();
            teamMottoTextBox.Clear();
            teamMembersTextBox.Clear();

            studentLeadTextBox.Clear();
            studentSubjectTextBox.Clear();
            studentGradeNumeric.Value = studentGradeNumeric.Minimum;

            newTaskTextBox.Clear();

            detailsLabel.Text = "Избери проект, за да видиш детайли.";
            tasksCheckedListBox.Items.Clear();
        }

        private void FillEditor(ClubProject project)
        {
            titleTextBox.Text = project.Title;
            themeTextBox.Text = project.Theme;

            mentorTextBox.Text = project.Mentor.FullName;
            mentorEmailTextBox.Text = project.Mentor.Email;
            mentorRoleTextBox.Text = project.Mentor.Role;

            dayComboBox.SelectedItem = project.MeetingDay;
            statusComboBox.SelectedItem = project.Status;

            notesTextBox.Text = project.Notes;

            teamNameTextBox.Text = project.Team.Name;
            teamMottoTextBox.Text = project.Team.Motto;
            teamMembersTextBox.Text = string.Join(
                Environment.NewLine,
                project.Team.Members.Select(m => $"{m.FirstName} {m.LastName}".Trim())
            );

            studentLeadTextBox.Text = $"{project.StudentLead.FirstName} {project.StudentLead.LastName}".Trim();
            studentSubjectTextBox.Text = project.StudentLead.FavoriteSubject;

            var grade = Math.Clamp(
                project.StudentLead.Grade,
                (int)studentGradeNumeric.Minimum,
                (int)studentGradeNumeric.Maximum
            );
            studentGradeNumeric.Value = grade;

            tasksCheckedListBox.Items.Clear();
            foreach (var task in project.Tasks)
            {
                int index = tasksCheckedListBox.Items.Add(task.Description);
                tasksCheckedListBox.SetItemChecked(index, task.IsCompleted);
            }

            newTaskTextBox.Clear();
        }

        private static string BuildDetails(ClubProject project)
        {
            var builder = new StringBuilder();

            builder.AppendLine($"{project.Title} ({project.Theme})");
            builder.AppendLine($"Ментор: {project.Mentor.FullName}");
            builder.AppendLine($"Събираме се в {project.MeetingDay}");
            builder.AppendLine($"Статус: {project.Status}");
            builder.AppendLine($"Екип: {project.Team.Name} ({project.Team.Motto})");
            builder.AppendLine($"Водещ ученик: {project.StudentLead}");
            if (!string.IsNullOrWhiteSpace(project.StudentLead.FavoriteSubject))
            {
                builder.AppendLine($"Любим предмет на лидера: {project.StudentLead.FavoriteSubject}");
            }
            builder.AppendLine("Членове:");

            foreach (var member in project.Team.Members)
            {
                builder.AppendLine($" • {member}");
            }

            if (project.Tasks.Count > 0)
            {
                builder.AppendLine("Задачи:");
                foreach (var task in project.Tasks)
                {
                    var done = task.IsCompleted ? "✔" : "…";
                    builder.AppendLine($" [{done}] {task.Description}");
                }
            }

            return builder.ToString();
        }

        private static List<Student> ParseMembers(string raw)
        {
            var result = new List<Student>();

            var lines = raw.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 0) continue;

                var first = parts[0];
                var last = parts.Length > 1 ? string.Join(' ', parts.Skip(1)) : string.Empty;

                result.Add(new Student
                {
                    FirstName = first,
                    LastName = last,
                    Grade = 10
                });
            }

            return result;
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            var text = newTaskTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(text)) return;

            tasksCheckedListBox.Items.Add(text, false);

            newTaskTextBox.Clear();
            newTaskTextBox.Focus();
        }

        private void RemoveTaskButton_Click(object sender, EventArgs e)
        {
            var idx = tasksCheckedListBox.SelectedIndex;
            if (idx >= 0)
            {
                tasksCheckedListBox.Items.RemoveAt(idx);
            }
        }
    }
}
