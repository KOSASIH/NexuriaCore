using Xunit;
using Moq;
using Microsoft.Extensions .Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nexuria.Core.QRBC;

namespace Nexuria.Core.UnitTests
{
    public class QRBCUnitTests
    {
        private readonly Mock<ILogger<QRBC>> _loggerMock;
        private readonly Mock<IConfiguration> _configurationMock;
        private readonly Mock<IServiceProvider> _serviceProviderMock;

        public QRBCUnitTests()
        {
            _loggerMock = new Mock<ILogger<QRBC>>();
            _configurationMock = new Mock<IConfiguration>();
            _serviceProviderMock = new Mock<IServiceProvider>();
        }

        [Fact]
        public async Task GenerateQRCodeAsync_QRCodeGenerated()
        {
            // Arrange
            var qRBC = new QRBC(_loggerMock.Object, _configurationMock.Object, _serviceProviderMock.Object);

            // Act
            var qrCode = await qRBC.GenerateQRCodeAsync("https://example.com");

            // Assert
            Assert.NotNull(qrCode);
        }

        [Fact]
        public async Task ValidateQRCodeAsync_QRCodeValidated()
        {
            // Arrange
            var qRBC = new QRBC(_loggerMock.Object, _configurationMock.Object, _serviceProviderMock.Object);

            // Act
            var isValid = await qRBC.ValidateQRCodeAsync("https://example.com");

            // Assert
            Assert.True(isValid);
        }
    }
}
