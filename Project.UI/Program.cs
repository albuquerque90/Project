using Project.Domain.Interface;
using Project.Domain.Services;
using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Project.Infra.Data.Interface;
using Project.Infra.Data.Repository;

namespace Project.UI
{
    static class Program
    {
        private static IServiceProvider ServiceProvider { get; set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IClienteServices, ClienteServices>();
            services.AddTransient<IClienteRepository, ClienteRepository>();
            ServiceProvider = services.BuildServiceProvider();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new Form1((IClienteServices)ServiceProvider.GetService(typeof(IClienteServices))));
        }
    }
}
