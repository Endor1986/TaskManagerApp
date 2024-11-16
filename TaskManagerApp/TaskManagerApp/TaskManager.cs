using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using TaskManagerApp.Models;

namespace TaskManagerApp
{
    public class TaskManager
    {
        private readonly List<UserTask> _tasks = new();

        public TaskManager()
        {
            _tasks = new List<UserTask>();
        }

        // Hinzufügen einer neuen Aufgabe
        public void AddTask(UserTask task)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task), "Task darf nicht null sein.");
            }
            _tasks.Add(task);
        }

        // Entfernen einer Aufgabe
        public void RemoveTask(UserTask task)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task), "Task darf nicht null sein.");
            }
            _tasks.Remove(task);
        }

        // Markieren einer Aufgabe als abgeschlossen
        public void MarkTaskAsCompleted(UserTask task)
        {
            var existingTask = _tasks.FirstOrDefault(t => t.Title == task.Title);
            if (existingTask != null)
            {
                existingTask.IsCompleted = true;
            }
        }

        // Alle Aufgaben abrufen
        public List<UserTask> GetAllTasks()
        {
            return new List<UserTask>(_tasks);
        }

        // Aufgaben nach Kategorie filtern
        public IEnumerable<UserTask> GetTasksByCategory(string category)
        {
            return _tasks.Where(t => t.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
        }

        // Überprüfen, ob es offene Aufgaben gibt
        public bool HasOpenTasks()
        {
            return _tasks.Any(t => !t.IsCompleted);
        }
    }
}
