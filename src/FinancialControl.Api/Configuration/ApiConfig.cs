﻿using FinancialControl.Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace FinancialControl.Api.Configuration
{
    public static class ApiConfig
    {
        public static void AddApiConfig(this IServiceCollection services, IConfiguration configuration)
        {
            var conn = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<Context>(options =>
            {
                options.UseSqlServer(conn);
            });

            services.AddControllers();

        }

        public static void UseApiConfig(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseIdentityConfig();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
