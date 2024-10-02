namespace ERPBackend.Settings.Domain.Address.Regions.Services;

public static class DependencyInjection
{
    public static IServiceCollection AddRegionServices(this IServiceCollection services)
    {
        services.AddScoped<IExistByNameRegionValidationSarvice, ExistByNameRegionValidationService>();
        services.AddScoped<IExistByCodeRegionValidationService, ExistByCodeRegionValidationService>();
        
        return services;
    }
}