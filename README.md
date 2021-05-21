# DDK

### Features

- Define aliases for your project commands (e.g. docker-compose commands)

## Installation
You can use NuGet to install the tool globally:
```bash
dotnet install DDK --global
```

## Configuration
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

## Usage
Defined commands can be executed by adding the command key name as first parameter (e.g. "version" if you use the example config file).
```bash
DDK version
```
