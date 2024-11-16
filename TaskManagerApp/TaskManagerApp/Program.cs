using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using TaskManagerApp.Interfaces;
using TaskManagerApp.Forms;
using TaskManagerApp.Services;
using TaskManagerApp;

namespace TaskManagerApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(
                serviceProvider.GetService<TaskManager>(),
                serviceProvider.GetService<ITaskLoader>(),
                serviceProvider.GetService<ITaskSaver>()));
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<ITaskLoader, FileManager>();
            services.AddSingleton<ITaskSaver, FileManager>();
            services.AddSingleton<ILicenseManager, LicenseManager>();
            services.AddSingleton<TaskManager>();
        }
    }
}
