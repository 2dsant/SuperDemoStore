using NSE.WebApp.MVC.Configuration;
using SDS.WebApp.MVC.Configuration;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", true, true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
    .AddEnvironmentVariables();

if (builder.Environment.IsDevelopment())
{
    builder.Configuration.AddUserSecrets(Assembly.GetExecutingAssembly(), true);
}

builder.Services
    .AddIdentityConfiguration()
    .AddMvcConfiguration(builder.Configuration)
    .RegisterServices();

var app = builder.Build();

app.UseMvcConfiguration();

app.Run();
