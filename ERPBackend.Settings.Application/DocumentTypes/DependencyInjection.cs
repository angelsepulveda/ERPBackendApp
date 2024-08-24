namespace ERPBackend.Settings.Application.DocumentTypes;

public static class DependencyInjection
{
    public static IServiceCollection AddDocumentTypesApplication(this IServiceCollection services)
    {
        services.AddDocumentTypesFeatures();
        
        return services;
    }
}