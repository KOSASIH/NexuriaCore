using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace Nexuria.NeuroNetwork
{
    public class NeuroNetworkService
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _configuration;
        private readonly IServiceProvider _serviceProvider;
        private readonly NeuroNetwork _neuroNetwork;

        public NeuroNetworkService(ILogger<NeuroNetworkService> logger, IConfiguration configuration, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _configuration = configuration;
            _serviceProvider = serviceProvider;
            _neuroNetwork = serviceProvider.GetService<NeuroNetwork>();
        }

        public async Task HandleRequestAsync(Matrix<double> inputs)
        {
            _logger.LogInformation("Handling NeuroNetwork request...");
            await _neuroNetwork.PredictAsync(inputs);
            _logger.LogInformation("NeuroNetwork request handled.");
        }
    }
}
