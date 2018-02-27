# DotNetCorewithAngular

Steps:

EntityFramework Core for MySql:
1. Add entity framework core for mysql: dotnet add package MySql.Data.EntityFrameworkCore;
2. Add entity framework design: dotnet add package Microsoft.EntityFrameworkCore.Design;

DbContext:
1. Create Dbcontext: Inherit from DbContext;
2. Implement IDesignTimeDbContextFactory
3. Register in ConfigureServices

AutoMapper: 
1. install automapper: dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 1.2.0;
2. Register automapper: int Startup.cs: services.AddAutoMapper();
3. Inherit Profile, CreateMap<>();
4. Used in controller: mapper.Map();

Apis:
1. Configure Makes, Features controllers

Angular:
1. Install cli: sudo npm install @angular/cli@latest -g;
2. Create new angular project: ng new hello-world;
3. Copy .angular-cli.json to project folder;
4. Change app-root-root:"src" into ClientApp;
5. Add vehicle-form component and register in module.shared;
6. Register new route for new component;
7. Add new link to navigation bar;
8. Mark up component.html

Services: to consume Apis
1. Generate make service: ng g service make;
2. Register make service into module as dependency injection provider;
3. Confiture vehicle-form conponents.ts;
4. Implement two-way binding for dropdown list;
