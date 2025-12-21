using SchoolClubManager.Services;
using SchoolClubManager.Services.Contracts;

namespace SchoolClubManager.App; 

static class Program 
{ 
    [STAThread] 
    static void Main() 
    { 
        ApplicationConfiguration.Initialize(); 
        IProjectService projectService = ProjectService.CreateSqlite();
        Application.Run(new MainForm(projectService));
    } 
}