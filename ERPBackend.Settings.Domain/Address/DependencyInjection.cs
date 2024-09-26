namespace ERPBackend.Settings.Domain.Address;

public static class DependencyInjection
{
    public static IServiceCollection AddAddressDomain(this IServiceCollection services)
    {
        services.AddCountriesDomain();
        
        return services;
    }
}