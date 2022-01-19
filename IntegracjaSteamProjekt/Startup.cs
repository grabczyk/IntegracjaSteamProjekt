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
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.TryAddSingleton<ISampleService, SampleService>();
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSoapEndpoint<ISampleService>("/SoapAPI.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
        }
    }

    public class StartupGateway
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddOcelot();
        }
        public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }          
            await app.UseOcelot();
        }
    }
}