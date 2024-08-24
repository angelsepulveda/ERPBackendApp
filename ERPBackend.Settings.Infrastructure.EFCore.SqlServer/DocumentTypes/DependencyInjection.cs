namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.DocumentTypes;

public static class DependencyInjection
{
    public static IServiceCollection AddDocumentTypesEFCoreSqlServer(this IServiceCollection services)
    {
        services.AddDocumentTypeRepositories();
        
        return services;
    }
}