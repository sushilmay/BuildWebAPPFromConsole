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

        /// <summary>
        /// Configure all middelware(is http pipeline) here via use(),next() and map() method.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints=> {

                //Diff  Map Vs MapGet is MapGet only use get request where Map may use get put and post etc.
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Running Web Server");
                });
            });
        }
    }
}
