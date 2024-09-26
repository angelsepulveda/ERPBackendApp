namespace ERPBackend.Settings.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddSettingsApplication(this IServiceCollection services)
    {
        services.AddDocumentTypesApplication();
        services.AddVoucherTypesApplication();
        services.AddAddressApplication();
        
        return services;
    }
    
}