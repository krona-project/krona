## Prerequisites

You will need Windows, Linux or macOS. Ubuntu 14 and 16 are supported. Ubuntu 17 is not supported.

Install [.NET Core](https://www.microsoft.com/net/download/core).

On Linux, install the LevelDB and SQLite3 dev packages. E.g. on Ubuntu:

```sh
sudo apt-get install libleveldb-dev sqlite3 libsqlite3-dev libunwind8-dev
```

On macOS, install the LevelDB package. E.g. install via Homebrew:

```
brew install --ignore-dependencies --build-from-source leveldb
```

On Windows, use the [Krona version of LevelDB](https://github.com/krona-project/leveldb).

## Download pre-compiled binaries

See also [official docs](https://developer.xknl.org). Download and unzip [latest release](https://github.com/krona-project/krona-cli/releases).

```sh
dotnet krona-cli.dll
```

## Compile from source

Clone the krona-project/krona repository.

```sh
cd krona
dotnet restore
dotnet publish -c Release
```
In order to run, you need .NET Core. Download the SDK [binary](https://www.microsoft.com/net/download/linux).

Assuming you extracted .NET in the parent folder:

```sh
../dotnet krona-cli/bin/Release/netcoreapp1.0/krona-cli.dll .
```

## Logging
To get event logs in krona-cli, you need to add the ApplicationLogs plugin. Copy and paste ApplicationLogs.dll and ApplicationLogs folder from krona/plugins/ApplicationLogs/bin/Release/netstandard2.0 into the krona-cli.dll Plugins folder.
