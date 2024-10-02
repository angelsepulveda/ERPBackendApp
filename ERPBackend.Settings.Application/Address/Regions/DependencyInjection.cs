namespace ERPBackend.Settings.Application.Address.Regions;

public static class DependencyInjection
{
    public static IServiceCollection AddRegionsApplication(this IServiceCollection services)
    {
        services.AddRegionsFeatures();
        
        return services;
    }
}