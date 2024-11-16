using System;
using System.Windows.Forms;
using TaskManagerApp.Models;
using TaskManagerApp.Interfaces;
using Task = TaskManagerApp.Models.UserTask;

namespace TaskManagerApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly TaskManager _taskManager;
        private readonly ITaskLoader _taskLoader;
        private readonly ITaskSaver _taskSaver;

        public MainForm(TaskManager taskManager, ITaskLoader taskLoader, ITaskSaver taskSaver)
        {
            InitializeComponent();
            _taskManager = taskManager;
            _taskLoader = taskLoader;
            _taskSaver = taskSaver;

            LoadTasks();
        }

        /// <summary>
        /// Lädt die Aufgaben aus der Datei und fügt sie dem TaskManager hinzu.
        /// </summary>
        private void LoadTasks()
        {
            var tasks = _taskLoader.LoadTasks("tasks.json");
            foreach (var task in tasks)
            {
                _taskManager.AddTask(task);
            }
            UpdateTaskList();
        }

        /// <summary>
        /// Aktualisiert die ListBox mit allen Aufgaben und zeigt Titel, Beschreibung und Kategorie an.
        /// </summary>
        private void UpdateTaskList()
        {
            listBoxTasks.Items.Clear();
            foreach (var task in _taskManager.GetAllTasks())
            {
                listBoxTasks.Items.Add(
                    $"{task.Title} | {task.Description} | {task.Category} | Fällig am: {task.DueDate.ToShortDateString()} | Status: {(task.IsCompleted ? "Erledigt" : "Offen")}"
                );
            }
        }

        /// <summary>
        /// Fügt eine neue Aufgabe hinzu und speichert die aktualisierte Liste.
        /// </summary>
        private void ButtonAddTask_Click(object sender, EventArgs e)
        {
            var title = textBoxTitle.Text;
            var description = textBoxDescription.Text;
            var category = textBoxCategory.Text;
            var dueDate = dateTimePickerDueDate.Value;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus.");
                return;
            }

            var newTask = new Task
            {
                Title = title,
                Description = description,
                Category = category,
                DueDate = dueDate,
                IsCompleted = false
            };

            _taskManager.AddTask(newTask);
            _taskSaver.SaveTasks(_taskManager.GetAllTasks(), "tasks.json");
            UpdateTaskList();
            MessageBox.Show("Aufgabe hinzugefügt.");
        }

        /// <summary>
        /// Markiert die ausgewählte Aufgabe als abgeschlossen.
        /// </summary>
        private void ButtonMarkCompleted_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex == -1)
            {
                MessageBox.Show("Bitte wählen Sie eine Aufgabe aus.");
                return;
            }

            var selectedTask = _taskManager.GetAllTasks()[listBoxTasks.SelectedIndex];
            selectedTask.IsCompleted = true;
            _taskSaver.SaveTasks(_taskManager.GetAllTasks(), "tasks.json");
            UpdateTaskList();
            MessageBox.Show("Aufgabe als abgeschlossen markiert.");
        }

        /// <summary>
        /// Löscht die ausgewählte Aufgabe aus dem TaskManager.
        /// </summary>
        private void ButtonDeleteTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex == -1)
            {
                MessageBox.Show("Bitte wählen Sie eine Aufgabe aus.");
                return;
            }

            var selectedTask = _taskManager.GetAllTasks()[listBoxTasks.SelectedIndex];
            _taskManager.RemoveTask(selectedTask);
            _taskSaver.SaveTasks(_taskManager.GetAllTasks(), "tasks.json");
            UpdateTaskList();
            MessageBox.Show("Aufgabe gelöscht.");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Hier können zusätzliche Ladevorgänge implementiert werden, falls erforderlich.
        }
    }
}
