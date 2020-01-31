## Requirement
* [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet-core) - 3.0.101
* [Git](https://git-scm.com/downloads)
* [Node](https://nodejs.org/en/download/)
* [VS Code](https://code.visualstudio.com/download)
* [Postman](https://www.getpostman.com/)
* [Docker Desktop](https://www.docker.com/products/docker-desktop)
* [Docket Toolbox](https://github.com/docker/toolbox/releases)

## Install Extension on VS Code
1. Install Extension Setting Sync
2. Add Gist ID is b56220dd30eb4abd1c8ccbc392a82a5a
3. Add Access Token is fddd371a05bcfa09bad0c2c9a93200bfb19b8a4d
4. Download All Extension (Shift + Alt + D)

## Install Dotnet Tool Entity Framework
Check Compatible between .NET Core Version and EF Tool Version
```
dotnet --version
dotnet tool install --global dotnet-ef --version 3.0.0
```

## Git Clone Project
[FirstTime]
```
git clone https://github.com/infraitc/project
```

[Update]
```
git pull
```

[Fix]
```
git reset --hard
```

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
docker exec -it fff1913dabfc /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P 'Tel1234!'
```

[Windows]
```
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Tel1234!" -p 1112:1433 -d mcr.microsoft.com/mssql/server:2017-CU14-ubuntu
docker exec -it fff1913dabfc /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P "Tel1234!"
```

## Connect Database
Connect Database via SQL Server extension not SQLTools extension
1. Add Connection
2. Add Server name (localhost,1112)
3. Add Database name (default)
4. Add Authentication (SQL Login)
5. Add User name (SA)
6. Add Password (Tel1234!)
7. Add Save Password (Yes)
8. Add Profile Name (mssql@localhost)

## Create Database
1. Run createdatabase.sql
2. Run insertdata.sql

## Create Project WebAPI
```
dotnet new webapi
```

## Add Certificate
```
dotnet tool install --global dotnet-dev-certs --version 3.0.0-preview-18579-0056
dotnet dev-certs https --clean
dotnet dev-cert https --trust
```

## Install NUGET Package in myapi.csproj
* [NUGET Package](https://www.nuget.org/packages/)
* [Entity Framework Core](https://docs.microsoft.com/th-th/ef/core/)
* [Oracle Data Provider](https://www.oracle.com/webfolder/technetwork/tutorials/obe/db/dotnet/ODPNET_Core_get_started/index.html)
* [LDAP](https://github.com/dsbenghe/Novell.Directory.Ldap.NETStandard)
* [Swagger](https://docs.microsoft.com/th-th/ASPNET/Core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.0&tabs=visual-studio)
* [JWT](https://github.com/jwt-dotnet/jwt#JwtNet-ASPNET-Core)
* [Auth0](https://auth0.com/authenticate/aspnet-core/active-directory/)

## Create Model Entity Framework
[DatabaseFirst]
```
dotnet ef dbcontext scaffold "Server=localhost,1112;user id=sa; password=Tel1234!; Database=CMPOS;" Microsoft.EntityFrameworkCore.SqlServer -o Models -t products -t users -c DatabaseContext --context-dir Database
```

## JGenerate Token JWT on WSL
```
echo "natthasath saksupanara" | sha256sum
8a77ef97a181786022b2b666f13964b8b15bfc5ce150a99b0068a469e7cb52dd  -
```

## What's new
https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-3.0

## Document
* [.NET Core Guide](https://docs.microsoft.com/en-us/dotnet/core/)
* [Logging](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/logging/?view=aspnetcore-3.1)
* [IHttpContextAccessor](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-context?view=aspnetcore-3.1)
* [IWebHostEnvironment](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/web-host?view=aspnetcore-3.1)
* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable?view=netcore-3.0)
* [IQuerable](https://docs.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1?view=netcore-3.0)
* [Task<TResult> Class](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1?view=netcore-3.0)
* [Repository](https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application)
* [String Interpolation](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/string-interpolation)
* [Hash Password](https://docs.microsoft.com/th-th/aspnet/core/security/data-protection/consumer-apis/password-hashing?view=aspnetcore-2.2)
* [CORS](https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-3.1)
* [.NET Core CLI](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet)
* [Swagger](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)
* [SMTP Client](https://docs.microsoft.com/en-us/dotnet/api/system.net.mail.smtpclient?view=netframework-4.8)
* [Fluent API](https://www.learnentityframeworkcore.com/configuration/data-annotation-attributes/databasegenerated-attribute)
* [Data Annotation Model](https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/data-annotations)
* [Code First](https://code-maze.com/net-core-web-development-part2/#creatingNewProject)
* [Migrate](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli)
* [DatabaseGenerated](https://www.entityframeworktutorial.net/code-first/databasegenerated-dataannotations-attribute.aspx)
* [Automapper]()