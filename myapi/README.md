## Requirement
* [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet-core) - 3.0.102
* [Git](https://git-scm.com/downloads)
* [Node](https://nodejs.org/en/download/)
* [VS Code](https://code.visualstudio.com/)
* [Docker](https://www.docker.com/products/docker-desktop)
* [Postman](https://www.getpostman.com/)

## Install Extension VS Code
* Install Extension Setting Sync
* Input Gist ID is b56220dd30eb4abd1c8ccbc392a82a5a
* Input Access Token is fddd371a05bcfa09bad0c2c9a93200bfb19b8a4d
* Shift + Alt + D

## Pull ImageDocker
docker pull mcr.microsoft.com/dotnet/core/sdk:3.0
docker pull mcr.microsoft.com/dotnet/core/aspnet:3.0
docker pull node:12.8-alpine
docker pull nginx:stable-alpine

## Install Dotnet Tool Entity Framework
- dotnet tool install --global dotnet-ef --version 3.0.0

## Documentation
* [.NET Core Guide](https://docs.microsoft.com/en-us/dotnet/core/)

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

