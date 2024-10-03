namespace ERPBackend.Settings.Domain.Address.Municipalities;

public static class DependencyInjection
{
    public static IServiceCollection AddMunicipalitiesDomain(this IServiceCollection services)
    {
        services.AddMunicipalitiesDomainServices();
        
        return services;
    }
}