using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace Nexuria.NeuroNetwork
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = BuildServiceProvider();
            var neuroNetwork = serviceProvider.GetService<NeuroNetwork>();

            await neuroNetwork.InitializeAsync();
            await neuroNetwork.TrainAsync(Matrix<double>.Build.Dense(10, 10), Matrix<double>.Build.Dense(10, 1));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            await neuroNetwork.PredictAsync(Matrix<double>.Build.Dense(10, 1));
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
                .AddSingleton<NeuroNetwork>()
                .AddSingleton<NeuroNetworkOptions>()
                .AddSingleton<IConfiguration>(configuration)
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
