namespace ERPBackend.Settings.Application.Address.Countries;

public static class DependencyInjection
{
    public static IServiceCollection AddCountriesApplication(this IServiceCollection services)
    {
        services.AddCountriesFeatures();
        
        return services;
    }
}