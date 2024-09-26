namespace ERPBackend.Settings.Application.Address;

public static class DependencyInjection
{
    public static IServiceCollection AddAddressApplication(this IServiceCollection services)
    {
        services.AddCountriesApplication();
        
        return services;
    }
}