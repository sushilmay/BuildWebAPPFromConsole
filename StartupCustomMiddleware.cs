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
    public class StartupCustomMiddleware
    {
        public void ConfigurationServices(IServiceCollection services)
        {

        }

        /// <summary>
        /// Configure all middelware(is http pipeline) here via use(),next() and map() method. order of middleware is vary important
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //use() method is used a new custom request pipeline
            app.Use(async (context, next) => {
                await context.Response.WriteAsync("\nCustom 1 middleware");
                await next(); 
                await context.Response.WriteAsync("\nResponse Custom 1 middleware");

            });

            app.Use(async (context, next) => {
                await context.Response.WriteAsync("\nCustom 2 middleware");
                await next();
                await context.Response.WriteAsync("\nResponse Custom 2 middleware");
            });

            app.Use(async (context, next) => {
                await context.Response.WriteAsync("\nCustom 3 middleware");
            });
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //Diff  Map Vs MapGet 
                //MapGet only use get request where Map may use get put and post etc.
                //Map() method is used for map a reource to a particular route
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Running Web Server");
                });
            });
        }
    }
}
