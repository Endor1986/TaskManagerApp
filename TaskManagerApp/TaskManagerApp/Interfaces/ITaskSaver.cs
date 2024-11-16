using System.Collections.Generic;
using TaskManagerApp.Models;

namespace TaskManagerApp.Interfaces
{
    public interface ITaskSaver
    {
        void SaveTasks(List<UserTask> tasks, string filePath);
    }
}
