using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;


namespace blog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Create IWebHostBuilder
            CreateWebHostBuilder(args)

            //Create a app's IWebHost
            .Build()

            //Start
            .Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)

                //Startup.cs-Startup class
                // .UseStartup<Startup>();
                // .UseStartup<StartupDevelopment>();
                .UseStartup(typeof(StartupDevelopment));
    }
}
