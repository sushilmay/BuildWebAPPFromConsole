﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BuildWebAPPFromConsole
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            //this method is used to add mvc in 3.0.1 version there are some more methods see commented below
            //services.AddMvc();
            
            //like for web api may use this one
            //services.AddControllers();  

            services.AddControllersWithViews();
        }

        /// <summary>
        /// Configure all middelware(is http pipeline) here via use(),next() and map() method.
        /// </summary>
        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {
            //here env variable read it form launchSetting.json file and as we know launchsetting only used for development
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();

            app.UseEndpoints(endpoints=> {

                //Diff  Map Vs MapGet is MapGet only use get request where Map may use get put and post etc.
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Running Web Server"+ env.EnvironmentName);
                //});
                
                endpoints.MapDefaultControllerRoute();

            });
        }
    }
}