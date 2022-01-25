﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace IntegracjaSteamProjekt
{
    /// <summary>
    /// Klasa obsługująca usługi soapAPI i APIGateway
    /// </summary>
    class Api
    {
        /// <summary>
        /// Statyczna funkcja budująca hosta API
        /// </summary>
        /// <param name="port">Port, na którym ma działać API</param>
        /// <param name="apiGatewayFlag">Wartość bool określająca czy tworzony host to APIGateway</param>
        /// <returns>Nowy host API</returns>
        public static IHostBuilder CreateHostBuilder(int port, bool apiGatewayFlag)
        {
            IHostBuilder host;
            if (apiGatewayFlag)
            {
                host = Host.CreateDefaultBuilder(Array.Empty<string>())
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
            else
            {
                host = Host.CreateDefaultBuilder(Array.Empty<string>())
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                    .UseUrls($"http://localhost:{port}/");
                });
            }
            return host;
        }
        /// <summary>
        /// Statyczna funkcja włączająca i wyłączająca soapAPI
        /// </summary>
        /// <param name="portNumber">Numer portu, na którym na działać soapAPI</param>
        public static void StartStopSoapApi(int portNumber)
        {
            Program.Form.soapApiStartButton.Enabled = false;
            Program.Form.SoapApiCancallationTokenSource = new();
            CancellationToken soapApiCancallationToken = Program.Form.SoapApiCancallationTokenSource.Token;
            Program.SoapApiTask = Task.Run(async () =>
            {
                bool running = true;
                IHost soapApiHost = Api.CreateHostBuilder(portNumber, false).Build();
                await soapApiHost.StartAsync();
                Program.Form.Context.Send(x => {
                    Program.Form.soapApiStateLabel.Text = "Running";
                    Program.Form.soapApiStateLabel.BackColor = Color.Green;
                    Program.Form.soapApiStopButton.Enabled = true;
                }, null);
                while (running)
                {
                    if (soapApiCancallationToken.IsCancellationRequested)
                    {
                        await soapApiHost.StopAsync();
                        Program.Form.Context.Send(x =>
                        {
                            Program.Form.soapApiStateLabel.Text = "Not running";
                            Program.Form.soapApiStateLabel.BackColor = Color.Red;
                            Program.Form.soapApiStartButton.Enabled = true;
                            Program.Form.soapApiStopButton.Enabled = false;
                        }, null);
                        running = false;
                        soapApiHost.Dispose();
                        Program.SoapApiTask = null;
                    }
                }
            });
            Program.Form.soapApiStopButton.Enabled = true;
        }

        /// <summary>
        /// Statyczna funkcja włączająca i wyłączająca APIGateway
        /// </summary>
        /// <param name="portNumber">Numer portu, na którym na działać APIGateway</param>
        public static void StartStopApiGateway(int portNumber)
        {
            Program.Form.apigatewayStartButton.Enabled = false;
            Program.Form.ApigatewayCancallationTokenSource = new();
            CancellationToken apiGatewayCancelationToken = Program.Form.ApigatewayCancallationTokenSource.Token;
            Program.ApiGatewayTask = Task.Run(async () =>
            {
                bool running = true;
                IHost apiGatewayHost = Api.CreateHostBuilder(portNumber, true).Build();
                await apiGatewayHost.StartAsync();
            Program.Form.Context.Send(x => {
                Program.Form.apiGatewayStateLabel.Text = "Running";
                Program.Form.apiGatewayStateLabel.BackColor = Color.Green;
                Program.Form.apiGatewayStopButton.Enabled = true;
                
                },null);
                while (running)
                {
                    if (apiGatewayCancelationToken.IsCancellationRequested)
                    {
                        await apiGatewayHost.StopAsync();
                        Program.Form.Context.Send(x => {
                            Program.Form.apiGatewayStateLabel.Text = "Not running";
                            Program.Form.apiGatewayStateLabel.BackColor = Color.Red;
                            Program.Form.apigatewayStartButton.Enabled = true;
                            Program.Form.apiGatewayStopButton.Enabled = false;
                        },null);
                        running = false;
                        apiGatewayHost.Dispose();
                        Program.ApiGatewayTask = null;
                    }
                }
            });
        }

    }
}
