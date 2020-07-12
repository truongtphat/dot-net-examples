using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Ttp.EfCore.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    var config = 
                        new ConfigurationBuilder()
                        .AddCommandLine(args)
                        .Build();

                    webBuilder
                        .UseConfiguration(config)
                        .UseStartup<Startup>();
                });
    }
}
