using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Todoist.Net.Models;
using TodoistNetTest.Helpers;
using TodoistNetTest.Objects;

namespace TodoistNetTest
{
    public partial class MainForm : Form
    {
        private Resources _allResources;
        private readonly BindingSource _dgBindingSource = new BindingSource();

        public const long MichaelId = 1879864L;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgTasks.DataSource = _dgBindingSource;

            const string apiTokenFileName = @"todoist.apikey";
            if (File.Exists(apiTokenFileName))
            {
                string apiToken = File.ReadAllText(apiTokenFileName);
                TodoistHelper.Initialize(apiToken);
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            GetResources();
        }

        private async void GetResources()
        {
            _allResources = await TodoistHelper.GetResources();

            IReadOnlyCollection<Item> tasks = _allResources.Items;
            IReadOnlyCollection<Project> projects = _allResources.Projects;
            IReadOnlyCollection<Note> taskComments = _allResources.Notes;

            IList<TodoistTask> todoistTasks = new List<TodoistTask>();

            foreach (Item task in tasks.Where(task =>
                   (task.IsChecked ?? false) == false
                && (task.InHistory ?? false) == false
                && (task.IsDeleted ?? false) == false
                && (task.IsArchived ?? false) == false
                && (task.Indent ?? 1) == 1
                && ((task.ResponsibleUid ?? 0) == MichaelId || (task.ResponsibleUid ?? 0) == 0)
                ))
            {
                Item task1 = task;
                IEnumerable<Note> notes = taskComments.Where(comment => comment.ItemId == task1.Id);
                Project project = projects.FirstOrDefault(proj => proj.Id == task.ProjectId);
                if (project != null)
                {
                    TodoistTask newTask = new TodoistTask
                    {
                        Content = task.Content,
                        DueDateUtc = task.DueDateUtc,
                        DateString = task.DateString,
                        ProjectName = project.Name
                    };
                    foreach (Note note in notes)
                    {
                        newTask.Comments.Add(new TaskComment { Content = note.Content, DateUtc = note.Posted });
                    }
                    todoistTasks.Add(newTask);
                }
            }

            _dgBindingSource.DataSource = todoistTasks.OrderBy(task => task.ProjectName).ThenBy(task => task.DueDateUtc).ThenBy(task => task.Content);
        }
    }
}