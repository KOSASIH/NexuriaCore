using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Nexuria.GAP;

namespace Nexuria.GAP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = BuildServiceProvider();
            var gap = serviceProvider.GetService<GlobalAdoptionPlatform>();

            await gap.InitializeAsync();
            await gap.StartAsync();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            await gap.StopAsync();
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
                .AddSingleton<GlobalAdoptionPlatform>()
                .AddSingleton<GAPOptions>()
                .AddSingleton<IConfiguration>(configuration)
                .AddDbContext<GAPDbContext>(options =>
                {
                    options.UseSqlServer(configuration.GetConnectionString("GAPDatabase"));
                })
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
