using SDS.Catalogo.API.Data.Repository;
using SDS.Identidade.API.Models;
using SDS.Catalogo.API.Data;

namespace SDS.Catalogo.API.Configuration;

public static class DependencyInjectionConfig
{
    public static WebApplicationBuilder RegisterServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
        builder.Services.AddScoped<CatalogoContext>();
        return builder;
    }
}
