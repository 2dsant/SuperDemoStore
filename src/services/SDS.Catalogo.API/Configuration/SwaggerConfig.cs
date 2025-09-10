using Microsoft.OpenApi.Models;

namespace SDS.Catalogo.API.Configuration;

public static class SwaggerConfig
{
    public static WebApplicationBuilder AddSwaggerConfiguration(this WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo()
            {
                Title = "SuperDemo Catalogo API",
                Description = "API para revisar conceitos de arquitetura distribuida.",
                Contact = new OpenApiContact() { Name = "David Santos", Email = "2dsant3@gmail.com" },
                License = new OpenApiLicense() { Name = "MIT", Url = new Uri("https://opensource.org/licenses/MIT") }
            });
        });

        return builder;
    }

    public static WebApplication UseSwaggerConfiguration(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        });

        return app;
    }
}
