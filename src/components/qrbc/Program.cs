using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Nexuria.QRBC
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = BuildServiceProvider();
            var qrbc = serviceProvider.GetService<QR BC>();

            await qrbc.InitializeAsync();
            await qrbc.StartAsync();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            await qrbc.StopAsync();
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
                .AddSingleton<QRBC>()
                .AddSingleton<QRBCOptions>()
                .AddSingleton<IConfiguration>(configuration)
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
