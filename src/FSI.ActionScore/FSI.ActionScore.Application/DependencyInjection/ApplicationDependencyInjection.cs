using FSI.ActionScore.Application.Interfaces;
using FSI.ActionScore.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FSI.ActionScore.Application.DependencyInjection
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IImpactTypeService, ImpactTypeService>();
            services.AddScoped<IUserAccountService, UserAccountService>();
            services.AddScoped<IActionModelService, ActionModelService>();
            services.AddScoped<IActionRecordService, ActionRecordService>();

            return services;
        }
    }
}