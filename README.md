[![World Bank](https://img.shields.io/badge/World%20Bank-Project%20Partner-orange)](https://www.worldbank.org/)
[![IMF](https://img.shields.io/badge/IMF-Research%20Collaborator-yellowgreen)](https://www.imf.org/)
[![UN](https://img.shields.io/badge/UN-Sustainable%20Development%20Goals-blue)](https://www.un.org/)
[![WHO](https://img.shields.io/badge/WHO-Global%20Health%20Partner-red)](https://www.who.int/)
[![IFC](https://img.shields.io/badge/IFC-Project%20Financing-green)](https://www.ifc.org/)
[![ADB](https://img.shields.io/badge/ADB-Regional%20Development%20Partner-orange)](https://www.adb.org/)
[![EBRD](https://img.shields.io/badge/EBRD-Project%20Investment-blue)](https://www.ebrd.com/)
[![AfDB](https://img.shields.io/badge/AfDB-Regional%20Integration%20Partner-yellowgreen)](https://www.afdb.org/)
[![IDB](https://img.shields.io/badge/IDB-Regional%20Development%20Partner-red)](https://www.iadb.org/)
[![OECD](https://img.shields.io/badge/OECD-Economic%20Development%20Partner-blue)](https://www.oecd.org/)
[![WTO](https://img.shields.io/badge/WTO-International%20Trade%20Partner-orange)](https://www.wto.org/)
[![ILO](https://img.shields.io/badge/ILO-Global%20Labour%20Standards-yellowgreen)](https://www.ilo.org/)
[![UNDP](https://img.shields.io/badge/UNDP-Sustainable%20Development%20Goals-blue)](https://www.undp.org/)
[![WIPO](https://img.shields.io/badge/WIPO-Intellectual%20Property%20Partner-red)](https://www.wipo.int/)
[![ITU](https://img.shields.io/badge/ITU-Global%20Telecommunication%20Standards-orange)](https://www.itu.int/)
[![UNICEF](https://img.shields.io/badge/UNICEF-Children's%20Rights%20Advocate-blue)](https://www.unicef.org/)
[![FAO](https://img.shields.io/badge/FAO-Global%20Food%20Security-yellowgreen)](https://www.fao.org/)
[![UNHCR](https://img.shields.io/badge/UNHCR-Refugee%20Protection%20Partner-orange)](https://www.unhcr.org/)
[![WWF](https://img.shields.io/badge/WWF-Conservation%20Partner-green)](https://www.worldwildlife.org/)
[![IOM](https://img.shields.io/badge/IOM-Migration%20Management%20Partner-red)](https://www.iom.int/)
[![UNEP](https://img.shields.io/badge/UNEP-Environmental%20Sustainability%20Partner-blue)](https://www.unep.org/)
[![ECB](https://img.shields.io/badge/ECB-European%20Central%20Bank-blue.svg)](https://www.ecb.europa.eu)
[![BIS](https://img.shields.io/badge/BIS-Bank%20for%20International%20Settlements-blue.svg)](https://www.bis.org)
[![ISO](https://img.shields.io/badge/ISO-International%20Organization%20for%20Standardization-blue.svg)](https://www.iso.org)
[![FSB](https://img.shields.io/badge/FSB-Financial%20Stability%20Board-blue.svg)](https://www.fsb.org)

<p xmlns:cc="http://creativecommons.org/ns#" xmlns:dct="http://purl.org/dc/terms/"><a property="dct:title" rel="cc:attributionURL" href="https://github.com/KOSASIH/NexuriaCore">Nexuria</a> by <a rel="cc:attributionURL dct:creator" property="cc:attributionName" href="https://www.linkedin.com/in/kosasih-81b46b5a">KOSASIH</a> is licensed under <a href="https://creativecommons.org/licenses/by/4.0/?ref=chooser-v1" target="_blank" rel="license noopener noreferrer" style="display:inline-block;">Creative Commons Attribution 4.0 International<img style="height:22px!important;margin-left:3px;vertical-align:text-bottom;" src="https://mirrors.creativecommons.org/presskit/icons/cc.svg?ref=chooser-v1" alt=""><img style="height:22px!important;margin-left:3px;vertical-align:text-bottom;" src="https://mirrors.creativecommons.org/presskit/icons/by.svg?ref=chooser-v1" alt=""></a></p>

[![Build Status](https://cdn.prod.website-files.com/5e0f1144930a8bc8aace526c/65dd9eb5aaca434fac4f1c7c_Build-Passing-brightgreen.svg)](https://github.com/KOSASIH/NexuriaCore/actions)
[![Code Coverage](https://codecov.io/gh/KOSASIH/NexuriaCore/branch/main/graph/badge.svg)](https://codecov.io/gh/KOSASIH/NexuriaCore)
[![License](https://img.shields.io/github/license/KOSASIH/NexuriaCore)](https://github.com/KOSASIH/NexuriaCore/blob/main/LICENSE)
[![Contributors](https://img.shields.io/github/contributors/KOSASIH/NexuriaCore)](https://github.com/KOSASIH/NexuriaCore/graphs/contributors)
[![Last Commit](https://img.shields.io/github/last-commit/KOSASIH/NexuriaCore)](https://github.com/KOSASIH/NexuriaCore/commits/main)
[![Open Issues](https://img.shields.io/github/issues/KOSASIH/NexuriaCore)](https://github.com/KOSASIH/NexuriaCore/issues)

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


