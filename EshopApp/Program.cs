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
            CreateHostBuilder(args).Run();
        }

        public static IWebHost CreateHostBuilder(string[] args) =>



           WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(SetuoConfiguration)
            .UseStartup<Startup>()
            .Build();

        private static void SetuoConfiguration(WebHostBuilderContext ctx, IConfigurationBuilder builder)
        {
            builder.Sources.Clear();
            builder.AddJsonFile("config.json", false, true)
                .AddXmlFile("config.xml", true)
                .AddEnvironmentVariables();
        }

      
    }
}
