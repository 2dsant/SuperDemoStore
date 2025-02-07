using NSE.WebApp.MVC.Configuration;
using SDS.WebApp.MVC.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddIdentityConfiguration()
    .AddMvcConfiguration()
    .RegisterServices();

var app = builder.Build();

app.UseMvcConfiguration();

app.Run();
