namespace ERPBackend.Settings.Application.Address.Municipalities;

public static class DependencyInjection
{
    public static IServiceCollection AddMunicipalitiesApplication(this IServiceCollection services)
    {
        services.AddMunicipalitiesFeatures();
        
        return services;
    }
}