using SDS.Catalogo.API.Configuration;
using SDS.WebAPI.Core.Identidade;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", true, true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
    .AddEnvironmentVariables();

if (builder.Environment.IsDevelopment())
{
    builder.Configuration.AddUserSecrets<Program>();
}

builder.AddApiConfiguration();

builder.AddJwtConfiguration();

builder.AddSwaggerConfiguration();

builder.RegisterServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwaggerConfiguration();

app.UseApiConfiguration();

app.UseHttpsRedirection();

app.Run();
