using FinancialControl.Infra.Data;
using Microsoft.AspNetCore.Identity;

namespace FinancialControl.Api.Configuration
{
    public static class IdentityConfig
    {
        public static IServiceCollection AddIdentityConfig(this IServiceCollection services)
        {
            //services.AddIdentity<IdentityUser, IdentityRole>()
            //    .AddEntityFrameworkStores<Context>()
            //    .AddDefaultTokenProviders();

            return services;
        }

        public static IApplicationBuilder UseIdentityConfig(this IApplicationBuilder app)
        {
            app.UseAuthentication();
            app.UseAuthorization();

            return app;
        }
    }
}
