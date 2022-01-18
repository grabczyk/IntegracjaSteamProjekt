using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace IntegracjaSteamProjekt
{
    static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Task task1 = Task.Run(CreateHostBuilder(args, 5000, false).Build().Run);
            Task task2 = Task.Run(CreateHostBuilder(args, 5200, false).Build().Run);
            Task task3 = Task.Run(CreateHostBuilder(args, 5300, true).Build().Run);
            Application.Run(new Form1());
        }

        public static IHostBuilder CreateHostBuilder(string[] args, int port, bool gatewayFlag)
        {
            IHostBuilder host;
            if (gatewayFlag)
            {
                host = Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<StartupGateway>()
                    .UseUrls($"http://localhost:{port}/");
                });
                host.ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.AddJsonFile("configuration.json");
                });
            }
            else {
                host = Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                    .UseUrls($"http://localhost:{port}/");
                });
            }
            return host;
        }
    }
}
