namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Countries;

public static class DependencyInjection
{
    public static IServiceCollection AddCountriesEFCoreSqlServer(this IServiceCollection services)
    {
        services.AddCountriesRepositories();
        
        return services;
    }
}