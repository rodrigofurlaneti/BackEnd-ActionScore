using FSI.ActionScore.Domain.Interfaces;
using FSI.ActionScore.Infrastructure.Persistence;
using FSI.ActionScore.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FSI.ActionScore.Infrastructure.DependencyInjection
{
    public static class InfrastructureDependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ActionScoreDb");

            services.AddDbContext<ActionScoreDbContext>(options =>
            {
                options.UseMySql(
                    connectionString,
                    ServerVersion.AutoDetect(connectionString));
            });

            services.AddScoped<IImpactTypeRepository, ImpactTypeRepository>();
            services.AddScoped<IUserAccountRepository, UserAccountRepository>();
            services.AddScoped<IActionModelRepository, ActionModelRepository>();
            services.AddScoped<IActionRecordRepository, ActionRecordRepository>();

            return services;
        }
    }
}