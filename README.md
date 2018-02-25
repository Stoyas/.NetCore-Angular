# DotNetCorewithAngular
EntityFramework Core for MySql:
1. dotnet add package MySql.Data.EntityFrameworkCore;
2. dotnet add package Microsoft.EntityFrameworkCore.Design;

DbContext:
1. Inherit from DbContext;
2. Implement IDesignTimeDbContextFactory
3. Register in ConfigureServices

AutoMapper: 
1. install automapper: dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 1.2.0;
2. Register automapper: int Startup.cs: services.AddAutoMapper();
3. Inherit Profile, CreateMap<>();
4. Used in controller: mapper.Map();
