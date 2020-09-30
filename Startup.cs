using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BuildWebAPPFromConsole
{
    public class Startup
    {

        public void ConfigurationServices(IServiceCollection services)
        {

        }

        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints=> {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Running Web Server");
                });
            });
        }
    }
}
