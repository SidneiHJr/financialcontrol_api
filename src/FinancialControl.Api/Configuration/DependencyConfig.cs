using FinancialControl.Core.Interfaces;
using FinancialControl.Domain.Notifications;
using FinancialControl.Domain.Services;
using FinancialControl.Infra.Data;

namespace FinancialControl.Api.Configuration
{
    public static class DependencyConfig
    {
        public static IServiceCollection AddDependencyConfig(this IServiceCollection services)
        {
            services.AddScoped(typeof(IService<>), typeof(Service<>));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<INotifiable, Notifiable>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
