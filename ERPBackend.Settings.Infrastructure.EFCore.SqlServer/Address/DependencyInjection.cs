namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address;

public static class DependencyInjection
{
    public static IServiceCollection AddAddressesEFCoreSqlServer(this IServiceCollection services)
    {
        services.AddCountriesEFCoreSqlServer();

        return services;
    }
}