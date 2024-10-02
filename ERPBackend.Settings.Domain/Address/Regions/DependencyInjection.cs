namespace ERPBackend.Settings.Domain.Address.Regions;

public static class DependencyInjection
{
    public static IServiceCollection AddRegionsDomain(this IServiceCollection services)
    {
        services.AddRegionServices();
        
        return services;
    }
}