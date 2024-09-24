using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nexuria.GAP.Models;

namespace Nexuria.GAP
{
    public class GlobalAdoptionPlatform
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _configuration;
        private readonly IServiceProvider _serviceProvider;
        private readonly GAPDbContext _dbContext;

        public GlobalAdoptionPlatform(ILogger<GlobalAdoptionPlatform> logger, IConfiguration configuration, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _configuration = configuration;
            _serviceProvider = serviceProvider;
            _dbContext = serviceProvider.GetService<GAPDbContext>();
        }

        public async Task InitializeAsync()
        {
            _logger.LogInformation("Initializing Global Adoption Platform...");
            _configuration.Bind("GAP", _serviceProvider.GetService<GAPOptions>());
            _logger.LogInformation("Global Adoption Platform initialized.");
        }

        public async Task StartAsync()
        {
            _logger.LogInformation("Starting Global Adoption Platform...");
            // Start the Global Adoption Platform services
            _logger.LogInformation("Global Adoption Platform started.");
        }

        public async Task StopAsync()
        {
            _logger.LogInformation("Stopping Global Adoption Platform...");
            // Stop the Global Adoption Platform services
            _logger.LogInformation("Global Adoption Platform stopped.");
        }

        public async Task AddAdoptionAsync(Adoption adoption)
        {
            _logger.LogInformation("Adding adoption to database...");
            _dbContext.Adoptions.Add(adoption);
            await _dbContext.SaveChangesAsync();
            _logger.LogInformation("Adoption added to database.");
        }

        public async Task GetAdoptionsAsync()
        {
            _logger.LogInformation("Retrieving adoptions from database...");
            var adoptions = await _dbContext.Adoptions.ToListAsync();
            _logger.LogInformation("Adoptions retrieved from database.");
            return adoptions;
        }
    }

    public class GAPOptions
    {
        public string DatabaseConnectionString { get; set; }
    }
}
