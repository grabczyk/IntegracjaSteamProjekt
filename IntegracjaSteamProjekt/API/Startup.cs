using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SoapCore;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Microsoft.Extensions.Hosting;

namespace IntegracjaSteamProjekt
{
    /// <summary>
    /// Klasa z typami startupu dla soapAPI
    /// </summary>
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.TryAddSingleton<ISoapApiService, SoapApiService>();
            services.AddMvc();
        }
        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSoapEndpoint<ISoapApiService>("/SoapAPI.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
        }
    }
    /// <summary>
    /// Klasa z typami startupu dla APIGateway
    /// </summary>
    public class StartupGateway
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddOcelot();
        }
        public static async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }          
            await app.UseOcelot();
        }
    }
}