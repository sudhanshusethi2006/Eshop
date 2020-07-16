using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EshopApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //when we use WebHost
            //CreateHostBuilder(args).Run();

            CreateHostBuilder(args).Build().Run();

        }

        //public static IWebHost CreateHostBuilder(string[] args) =>



        //   WebHost.CreateDefaultBuilder(args)
        //    .ConfigureAppConfiguration(SetuoConfiguration)
        //    .UseStartup<Startup>()
        //    .Build();


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostContext, config) =>
            {
                var env = hostContext.HostingEnvironment;

                config.AddJsonFile("config.json", optional: true, reloadOnChange: true)
                  .AddJsonFile($"config.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
            })
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });


         //WebHost.CreateDefaultBuilder(args)
         // .ConfigureAppConfiguration(SetuoConfiguration)
         // .UseStartup<Startup>()
         // .Build();

        private static void SetuoConfiguration(WebHostBuilderContext ctx, IConfigurationBuilder builder)
        {
            builder.Sources.Clear();
            builder.AddJsonFile("config.json", false, true)
                .AddXmlFile("config.xml", true)
                .AddEnvironmentVariables();
        }

      
    }
}
