using SDS.Identidade.API.Configuration;
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

builder.AddIdentityConfiguration()
    .AddApiConfiguration()
    .AddSwaggerConfiguration();

var app = builder.Build();

app.UseApiConfiguration()
    .UseSwaggerConfiguration();

app.Run();
