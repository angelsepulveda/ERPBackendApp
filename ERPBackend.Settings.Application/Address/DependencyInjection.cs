namespace ERPBackend.Settings.Application.Address;

public static class DependencyInjection
{
    public static IServiceCollection AddAddressApplication(this IServiceCollection services)
    {
        services.AddCountriesApplication();
        services.AddRegionsApplication();
        services.AddMunicipalitiesApplication();
        
        return services;
    }
}