# Web API
AMS (Account Management System) Web API with .NET Core is OpenSource Framework Cross Platform

## Requirement
* [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet-core) - 3.0.101
* [NuGet Package](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/)
* [Postman](https://www.getpostman.com/)

## Documentation
* [.NET Core Guide](https://docs.microsoft.com/en-us/dotnet/core/)

## Step 1: Install .NET Entity Framework Core Tool with Terminal
Check Compatible between .NET Core Version and EF Tool Version
```
dotnet --version
dotnet tool install --global dotnet-ef --version 3.0.0
```
Enable Entity Framework Command
```
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet ef migrations add AddProductReviews
dotnet ef migrations remove
dotnet ef database update LastGoodMigration
dotnet ef migrations list
dotnet ef migrations script
dotnet ef dbcontext info
dotnet ef dbcontext scaffold
dotnet ef database drop
dotnet ef database update
```

## Step 2: Install .NET Core Web API with Terminal
```
dotnet new webapi
```

## Step 3: Install NuGet Package with project.csproj
[Entity Framework Core](https://docs.microsoft.com/th-th/ef/core/)
```
<ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="2.2.6" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="2.2.6">
        <PrivateAssets>all</PrivateAssets>
        <IncludeAssets>runtime; build; native; contentfiles; analyzers</IncludeAssets>
    </PackageReference>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="2.2.6">
        <PrivateAssets>all</PrivateAssets>
        <IncludeAssets>runtime; build; native; contentfiles; analyzers</IncludeAssets>
    </PackageReference>
</ItemGroup>
```

[Oracle Data Provider](https://www.oracle.com/webfolder/technetwork/tutorials/obe/db/dotnet/ODPNET_Core_get_started/index.html)
```
<ItemGroup>
    <PackageReference Include="Oracle.ManagedDataAccess.Core" Version="2.19.50" />
    <PackageReference Include="Oracle.ManagedDataAccess.EntityFramework" Version="19.6.0" />
    <PackageReference Include="Oracle.EntityFrameworkCore" Version="2.19.50" />
</ItemGroup>
```

[LDAP](https://github.com/dsbenghe/Novell.Directory.Ldap.NETStandard)
```
<ItemGroup>
    <PackageReference Include="Novell.Directory.Ldap.NETStandard" Version="3.0.0-beta6" />
</ItemGroup>
```

[Swagger](https://docs.microsoft.com/th-th/ASPNET/Core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.0&tabs=visual-studio)
```
<ItemGroup>
    <PackageReference Include="Swashbuckle.AspNetCore" Version="5.0.0-rc4" />
    <PackageReference Include="Swashbuckle.AspNetCore.Annotations" Version="5.0.0-rc4" />
    <PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="7.0.0" />
</ItemGroup>
```

[JWT](https://github.com/jwt-dotnet/jwt#JwtNet-ASPNET-Core)
```
<ItemGroup>
    <PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" Version="3.0.0" />
</ItemGroup>
```

[Auth0](https://auth0.com/authenticate/aspnet-core/active-directory/)
```
<ItemGroup>
    <PackageReference Include="Microsoft.AspNetCore.Authentication.Cookies" Version="2.2.0" />
    <PackageReference Include="Microsoft.AspNetCore.Authentication.OpenIdConnect" Version="2.2.0" />
</ItemGroup>
```