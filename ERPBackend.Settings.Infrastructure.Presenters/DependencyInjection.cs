namespace ERPBackend.Settings.Infrastructure.Presenters;

public static class DependencyInjection
{
    public static IServiceCollection AddSettingsPresenters(this IServiceCollection services)
    {
        services.AddDocumentTypePresenters();
        
        return services;
    }
}