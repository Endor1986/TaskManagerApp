using System.Collections.Generic;
using TaskManagerApp.Models;

namespace TaskManagerApp.Interfaces
{
    public interface ITaskLoader
    {
        List<UserTask> LoadTasks(string filePath);
    }
}
