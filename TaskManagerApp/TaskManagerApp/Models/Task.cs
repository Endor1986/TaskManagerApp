using System;

namespace TaskManagerApp.Models
{
    public class UserTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Category { get; set; }
        public bool IsCompleted { get; set; }
    }
}
