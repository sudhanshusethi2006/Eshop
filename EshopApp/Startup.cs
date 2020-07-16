using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EshopApp.Data;
using EshopApp.services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EshopApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
                Configuration = configuration;
            }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddTransient<IMailService, NullMailService>();

            services.AddDbContext<EshopContext>(cfg => cfg.UseSqlServer(Configuration.GetConnectionString("EshopConnectionString")));
            //before .net 3.0 core
            //services.AddMvc();

            services.AddMvc();
            // in.net 3.0  core
            services.AddControllersWithViews();

         //   services.AddTransient<EshopContext>();

            // connection string for docker on mac
            //services.AddDbContext<EshopContext>(cfg => cfg.UseSqlServer("Server=localhost,1433; Database=EshopDB;User=SA; Password=Canada@007"));


            

       
        
   
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // if (env.IsDevelopment())
            // {
            //     app.UseDeveloperExceptionPage();
            // }
            // else
            // {
            //     app.UseExceptionHandler("/Home/Error");
            //     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //     app.UseHsts();
            // }
            // app.UseHttpsRedirection();
            // app.UseStaticFiles();
            //
            // app.UseRouting();
            //
            // app.UseAuthorization();
            //
            // app.UseEndpoints(endpoints =>
            // {
            //     endpoints.MapControllerRoute(
            //         name: "default",
            //         pattern: "{controller=Home}/{action=Index}/{id?}");
            // });
            //
            
            
            // to show a simple text
            // app.Run(async context =>
            // {
            //     await context.Response.WriteAsync("<html><h1>sudhanshu sethi</h1> </html>");
            // });


// file which are only wwwwroot directory
            // app.UseDefaultFiles();

            if (env.IsDevelopment())
            {
               app.UseDeveloperExceptionPage();

            }
            else
            {
                app.UseExceptionHandler("/Error");
            }
                
            app.UseStaticFiles();

            app.UseNodeModules();
            app.UseRouting();
            app.UseEndpoints(x => x.MapControllerRoute("Fallback", "{controller}/{action}/{id?}", new { Controller="App", action="Index" } ));


            app.UseFileServer();

        }
    }
}
