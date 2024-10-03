namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Municipalities;

public static class DependencyInjection
{
    public static IServiceCollection AddMunicipalitiesEFCoreSqlServer(this IServiceCollection services)
    {
        services.AddMunicipalitiesRepositories();
        
        return services;
    }
}