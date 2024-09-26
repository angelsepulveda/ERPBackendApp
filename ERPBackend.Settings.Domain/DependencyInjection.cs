namespace ERPBackend.Settings.Domain;

public static class DependencyInjection
{
    public static IServiceCollection AddSettingsDomain(this IServiceCollection services)
    {
        services.AddAddressDomain();
        
        return services;
    }
}