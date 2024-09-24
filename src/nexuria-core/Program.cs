using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Nexuria
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = BuildServiceProvider();
            var nexuriaCore = serviceProvider.GetService<NexuriaCore>();

            nexuriaCore.Initialize();
            nexuriaCore.Start();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            nexuriaCore.Stop();
        }

        static IServiceProvider BuildServiceProvider()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var serviceProvider = new ServiceCollection()
                .AddLogging(logging =>
                {
                    logging.AddConsole();
                    logging.AddDebug();
                })
                .AddSingleton<NexuriaCore>()
                .AddSingleton<NexuriaOptions>()
                .AddSingleton<IConfiguration>(configuration)
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
