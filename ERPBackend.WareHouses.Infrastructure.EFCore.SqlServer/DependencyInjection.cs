namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer;

public static class DependencyInjection
{
    public static IServiceCollection AddWareHousesEFCoreSqlServer(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddCoreWareHousesEFCoreSqlServer(configuration);
        services.AddCategoriesEFCoreSqlServer();
        services.AddBrandsEFCoreSqlServer();
        services.AddMeasurementUnitsEFCoreSqlServer();
        
        return services;
    }
}