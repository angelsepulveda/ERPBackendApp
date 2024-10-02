namespace ERPBackend.Settings.Domain.Address.Countries.Services;

public static class DependencyInjection
{
    public static IServiceCollection AddCountriesDomainServices(this IServiceCollection services)
    {
        services.AddScoped<IExistByCodeCountryService, ExistByCodeCountryService>();
        services.AddScoped<IExistByNameCountryService, ExistByNameCountryService>();
        
        return services;
    }
}