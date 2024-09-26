namespace ERPBackend.Settings.Domain.Address.Countries;

public static class DependencyInjection
{
    public static IServiceCollection AddCountriesDomain(this IServiceCollection services)
    {
        services.AddCountriesDomainServices();
        
        return services;
    }

}