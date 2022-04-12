<!-- PROJECT SHIELDS -->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]
[![.NET Core][net-core-shield]][net-core-url]

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <!--<a href="https://github.com/Tim-Koertgen/DDK">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>-->

<h3 align="center">DDK</h3>

  <p align="center">
    <br />
    <a href="https://github.com/Tim-Koertgen/DDK"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/Tim-Koertgen/DDK/issues">Report Bug</a>
    ·
    <a href="https://github.com/Tim-Koertgen/DDK/issues">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

- Define aliases for your project commands (e.g. docker-compose commands)

<p align="right">(<a href="#top">back to top</a>)</p>



### Built With

* [.NET Core 3.1](https://docs.microsoft.com/de-de/dotnet/core/whats-new/dotnet-core-3-1)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

### Prerequisites

All you need to do is install the .NET Core 3.1 Runtime or for developing the tool the .NET Core 3.1 SDK

### Installation

#### NuGet

1. Use NuGet to install the tool globally
   ```sh
   dotnet tool install --global DDK --version 1.0.0
   ```

#### Build it yourself

1. Clone the repo
   ```sh
   git clone https://github.com/Tim-Koertgen/DDK.git
   ```
2. Open the project in Visual Studio and press F5 to build

#### Download a release build

Head over to the [releases page](https://github.com/Tim-Koertgen/DDK/releases) to get the latest version of the tool

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage

The config file needs to be placed in the project / execution directory of the DDK tool.

### Example config file

```json
{
  "groups": {
    "docker": {
      "version": {
        "commands": [
          "docker-compose --version",
          "docker --version"
        ],
        "description": "Displays docker-compose and docker version information"
      }
    }
  }
}

```

Defined commands can be executed by adding the command key name as first parameter (e.g. "version" if you use the example config file).
```bash
DDK version
```

<!--_For more examples, please refer to the [Documentation](https://example.com)_-->
_Documentation is in progress_

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- ROADMAP -->
## Roadmap

See the [open issues](https://github.com/Tim-Koertgen/DDK/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Tim Körtgen - [@SirPhoeniix](https://twitter.com/SirPhoeniix) - tim.koertgen@outlook.de

Project Link: [https://github.com/Tim-Koertgen/DDK](https://github.com/Tim-Koertgen/DDK)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- ACKNOWLEDGMENTS -->
<!--## Acknowledgments

* []()
* []()
* []()

<p align="right">(<a href="#top">back to top</a>)</p>-->



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/Tim-Koertgen/DDK.svg?style=for-the-badge
[contributors-url]: https://github.com/Tim-Koertgen/DDK/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/Tim-Koertgen/DDK.svg?style=for-the-badge
[forks-url]: https://github.com/Tim-Koertgen/DDK/network/members
[stars-shield]: https://img.shields.io/github/stars/Tim-Koertgen/DDK.svg?style=for-the-badge
[stars-url]: https://github.com/Tim-Koertgen/DDK/stargazers
[issues-shield]: https://img.shields.io/github/issues/Tim-Koertgen/DDK.svg?style=for-the-badge
[issues-url]: https://github.com/Tim-Koertgen/DDK/issues
[license-shield]: https://img.shields.io/github/license/Tim-Koertgen/DDK.svg?style=for-the-badge
[license-url]: https://github.com/Tim-Koertgen/DDK/blob/main/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/tim-körtgen
[net-core-shield]: https://img.shields.io/badge/.NET%20Core-3.1-red.svg?style=for-the-badge
[net-core-url]: https://docs.microsoft.com/de-de/dotnet/core/whats-new/dotnet-core-3-1
