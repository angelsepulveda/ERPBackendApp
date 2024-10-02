namespace ERPBackend.Settings.Domain.Address;

public static class DependencyInjection
{
    public static IServiceCollection AddAddressDomain(this IServiceCollection services)
    {
        services.AddCountriesDomain();
        services.AddRegionsDomain();
        
        return services;
    }
}