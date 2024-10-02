namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Regions;

public static class DependencyInjection
{
    public static IServiceCollection AddRegionsEFCoreSqlServer(this IServiceCollection services)
    {
        services.AddRegionsRepositories();
        
        return services;
    }
}