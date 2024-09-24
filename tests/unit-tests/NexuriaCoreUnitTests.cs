using Xunit;
using Moq;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nexuria.Core;

namespace Nexuria.Core.UnitTests
{
    public class NexuriaCoreUnitTests
    {
        private readonly Mock<ILogger<NexuriaCore>> _loggerMock;
        private readonly Mock<IConfiguration> _configurationMock;
        private readonly Mock<IServiceProvider> _serviceProviderMock;

        public NexuriaCoreUnitTests()
        {
            _loggerMock = new Mock<ILogger<NexuriaCore>>();
            _configurationMock = new Mock<IConfiguration>();
            _serviceProviderMock = new Mock<IServiceProvider>();
        }

        [Fact]
        public async Task InitializeAsync_LoggerInitialized_ConfigurationBound()
        {
            // Arrange
            var nexuriaCore = new NexuriaCore(_loggerMock.Object, _configurationMock.Object, _serviceProviderMock.Object);

            // Act
            await nexuriaCore.InitializeAsync();

            // Assert
            _loggerMock.Verify(l => l.LogInformation(It.IsAny<string>()), Times.Once);
            _configurationMock.Verify(c => c.Bind(It.IsAny<string>(), It.IsAny<object>()), Times.Once);
        }

        [Fact]
        public async Task StartAsync_ServiceStarted()
        {
            // Arrange
            var nexuriaCore = new NexuriaCore(_loggerMock.Object, _configurationMock.Object, _serviceProviderMock.Object);

            // Act
            await nexuriaCore.StartAsync();

            // Assert
            _loggerMock.Verify(l => l.LogInformation(It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public async Task StopAsync_ServiceStopped()
        {
            // Arrange
            var nexuriaCore = new NexuriaCore(_loggerMock.Object, _configurationMock.Object, _serviceProviderMock.Object);

            // Act
            await nexuriaCore.StopAsync();

            // Assert
            _loggerMock.Verify(l => l.LogInformation(It.IsAny<string>()), Times.Once);
        }
    }
}
