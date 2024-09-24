# NexuriaCore
The central repository for Project [Nexuria](docs), housing the overall project architecture and integration of its components.

Nexuria Core
================

Nexuria Core is a .NET 6.0 library that provides a set of advanced features for building high-performance applications.

Features
--------

* Advanced logging and configuration management
* Dependency injection and service provider
* QR code generation and validation
* Integration with Azure services

Getting Started
---------------

To get started with Nexuria Core, simply install the NuGet package:

`1. dotnet add package Nexuria.Core`


Then, import the namespace and start using the library:

```csharp
1. using Nexuria.Core;
2. 
3. // Initialize the Nexuria Core instance
4. var nexuriaCore = new NexuriaCore();
5. 
6. // Use the library features
7. var qrCode = await nexuriaCore.GenerateQRCodeAsync("https://example.com");
```

## Contributing

Contributions are welcome! If you'd like to contribute to Nexuria Core, please fork the repository and submit a pull request.

## License

Nexuria Core is licensed under the Apache 2.0 License. See LICENSE for details.

## Author

Nexuria Core is maintained by [KOSASIH](https://www.linkedin.com/in/kosasih-81b46b5a).

# Acknowledgments

Nexuria Core uses the following open-source libraries:

1. Microsoft.Extensions.Logging
2. Microsoft.Extensions.Configuration
3. Moq
4. xunit

Thanks to the maintainers of these libraries for their hard work!


