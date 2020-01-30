## Install Dotnet Tool Entity Framework
- dotnet tool install --global dotnet-ef --version 3.0.0

## Install NUGET Package in myapi.csproj
- <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="3.0.1" />
- <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="3.0.1">
    <PrivateAssets>all</PrivateAssets>
    <IncludeAssets>runtime; build; native; contentfiles; analyzers</IncludeAssets>
  </PackageReference>
- run "dotnet restore" in terminal
- [NUGET Package](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/)

## Entity Framework
dotnet ef dbcontext scaffold "Server=localhost,1112;user id=sa; password=Tel1234!; Database=CMPOS;" Microsoft.EntityFrameworkCore.SqlServer -o Models -t products -t users -c DatabaseContext --context-dir Database

## Certificate
- dotnet dev-cert https --trust

## Data Annotation
- []

wildermind
c# extension
refresh token access token => oauth

## What's new
https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-3.0

## Automapper

## Service in Controller (Contructor)

## Docker
docker pull mcr.microsoft.com/dotnet/core/sdk:3.0
docker pull mcr.microsoft.com/dotnet/core/aspnet:3.0
docker pull node:12.8-alpine
docker pull nginx:stable-alpine## Requirement
* [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet-core) - 3.0.102
* [Git](https://git-scm.com/downloads)
* [Node](https://nodejs.org/en/download/)
* [VS Code](https://code.visualstudio.com/)
* [Docker](https://www.docker.com/products/docker-desktop)
* [Docker Toolbox]()
* [Postman](https://www.getpostman.com/)

## Install Extension VS Code
1. Install Extension Setting Sync
2. Input Gist ID is b56220dd30eb4abd1c8ccbc392a82a5a
3. Input Access Token is fddd371a05bcfa09bad0c2c9a93200bfb19b8a4d
4. Shift + Alt + D

## Pull Image Docker
```
docker pull mcr.microsoft.com/dotnet/core/sdk:3.0
docker pull mcr.microsoft.com/dotnet/core/aspnet:3.0
docker pull node:12.8-alpine
docker pull nginx:stable-alpine
```

## Run Container Docker
Can't run container on VMware Workstation because docker use Hyper-V but it's fix enable Intel VT-x/EPT or AMD-V/RVI in Virtual Machine Setting
[Linux]
```
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Tel1234!' -p 1112:1433 -d mcr.microsoft.com/mssql/server:2017-CU14-ubuntu
```

[Windows]
```
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Tel1234!" -p 1112:1433 -d mcr.microsoft.com/mssql/server:2017-CU14-ubuntu
```

## Connect SQL Server Container via extension on VS Code
1. Add Connection
2. Specific Server name with port (localhost,1112)
3. Enter Database name
4. Enter SQL Login
5. Specific User name (sa)
6. Specific Password (Tel1234!)

## SQL
```
docker exec -it fff1913dabfc /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P "Tel1234!"
docker exec -it fff1913dabfc /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "Tel1234!" -Q "BACKUP DATABASE cmpos TO DISK = '/var/opt/mssql/cmpos.bak' WITH FORMAT, INIT, COMPRESSION, STATS = 10"
```

## Install Dotnet Tool Entity Framework
- dotnet tool install --global dotnet-ef --version 3.0.0

## Documentation
* [.NET Core Guide](https://docs.microsoft.com/en-us/dotnet/core/)

## Get Started New Web API
```
dotnet new webapi
```

## Install NUGET Package in myapi.csproj
- <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="3.0.1" />
- <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="3.0.1">
    <PrivateAssets>all</PrivateAssets>
    <IncludeAssets>runtime; build; native; contentfiles; analyzers</IncludeAssets>
  </PackageReference>
- run "dotnet restore" in terminal
- [NUGET Package](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/)

## Entity Framework
dotnet ef dbcontext scaffold -f "Server=localhost,1112;user id=sa; password=Tel1234!; Database=CMPOS;" Microsoft.EntityFrameworkCore.SqlServer -o Models -t products -t users -c DatabaseContext --context-dir Database

## Certificate
- dotnet dev-cert https --trust

## Data Annotation
- []

wildermind
c# extension
refresh token access token => oauth

## What's new
https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-3.0

## Automapper

## Service in Controller (Contructor)

