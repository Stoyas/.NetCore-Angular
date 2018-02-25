# DotNetCorewithAngular
AutoMapper: 
1. install automapper: dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 1.2.0
2. Register automapper: int Startup.cs: services.AddAutoMapper();
3. Inherit Profile, CreateMap<>();
4. Used in controller: mapper.Map();
