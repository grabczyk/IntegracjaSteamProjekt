using System.ServiceModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SoapCore;
using System.Threading;
using System.Threading.Tasks;
using Ocelot;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace IntegracjaSteamProjekt
{
    public class Startup
    {
        public bool gateway { get; set; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.TryAddSingleton<ISampleService, SampleService>();
            services.AddMvc();
           // if (gateway)
           // {
               // services.AddOcelot();
            //}
        }
        public async void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
           // if (gateway)
           // {
                //await app.UseOcelot();
           // }
           // else
          //  {
                app.UseSoapEndpoint<ISampleService>("/Service.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
           // }
           
            

        }
    }

    public class StartupGateway
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOcelot();
        }
        public async void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            await app.UseOcelot();



        }
    }
}