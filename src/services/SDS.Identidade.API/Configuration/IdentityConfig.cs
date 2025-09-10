using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SDS.Identidade.API.Extensions;
using SDS.WebAPI.Core.Identidade;
using SDS.Identidade.API.Data;

namespace SDS.Identidade.API.Configuration;

public static class IdentityConfig
{
    public static WebApplicationBuilder AddIdentityConfiguration(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        builder.Services.AddDefaultIdentity<IdentityUser>()
            .AddRoles<IdentityRole>()
                .AddErrorDescriber<IdentityMensagemPortugues>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

        builder.AddJwtConfiguration();

        return builder;
    }
}
