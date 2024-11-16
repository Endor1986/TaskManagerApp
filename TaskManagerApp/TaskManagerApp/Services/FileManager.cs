using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using TaskManagerApp.Interfaces;
using TaskManagerApp.Models;
using JsonFormatting = Newtonsoft.Json.Formatting;

namespace TaskManagerApp.Services
{
    public class FileManager : ITaskLoader, ITaskSaver
    {
        public List<UserTask> LoadTasks(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<UserTask>();

            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<UserTask>>(json);
        }

        public void SaveTasks(List<UserTask> tasks, string filePath)
        {
            var json = JsonConvert.SerializeObject(tasks, JsonFormatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}

