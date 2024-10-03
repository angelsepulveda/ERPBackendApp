namespace ERPBackend.Settings.Domain.Address.Municipalities.Services;

public static class DependencyInjection
{
    public static IServiceCollection AddMunicipalitiesDomainServices(this IServiceCollection services)
    {
        services.AddScoped<IExitsByCodeMunicipalityValidationService, ExitsByCodeMunicipalityValidationService>();
        services.AddScoped<IExitsByNameMunicipalityValidationService, ExitsByNameMunicipalityValidationService>();

        return services;
    }
}