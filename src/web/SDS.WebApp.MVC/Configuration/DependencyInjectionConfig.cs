using SDS.WebApp.MVC.Extensions;
using SDS.WebApp.MVC.Services;

namespace SDS.WebApp.MVC.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddHttpClient<IAutenticacaoService, AutenticacaoService>();
            // Como o HttpContext em si já é gerenciado pelo ASP.NET Core e é Scoped, o IHttpContextAccessor pode ser Singleton, pois apenas referencia o HttpContext correto da requisição atual.
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); 
            services.AddScoped<IUser, AspNetUser>();
        }
    }
}
