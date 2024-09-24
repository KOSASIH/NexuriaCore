using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nexuria.QRBC
{
    public class QRBC
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _configuration;
        private readonly IServiceProvider _serviceProvider;

        public QRBC(ILogger<QRBC> logger, IConfiguration configuration, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _configuration = configuration;
            _serviceProvider = serviceProvider;
        }

        public async Task InitializeAsync()
        {
            _logger.LogInformation("Initializing QRBC...");
            _configuration.Bind("QRBC", _serviceProvider.GetService<QRBCOptions>());
            _logger.LogInformation("QRBC initialized.");
        }

        public async Task StartAsync()
        {
            _logger.LogInformation("Starting QRBC...");
            // Start the QRBC service
            _logger.LogInformation("QRBC started.");
        }

        public async Task StopAsync()
        {
            _logger.LogInformation("Stopping QRBC...");
            // Stop the QRBC service
            _logger.LogInformation("QRBC stopped.");
        }
    }

    public class QRBCOptions
    {
        public string Url { get; set; }
        public int Port { get; set; }
    }
}
