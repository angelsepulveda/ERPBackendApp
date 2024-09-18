namespace ERPBackend.WareHouses.CrossCutting.IoCs;

public static class DependencyInjection
{
    public static IServiceCollection AddWareHousesServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddWareHousesApplication()
            .AddWareHousesEFCoreSqlServer(configuration)
            .AddWareHousesPresenters()
            .AddWareHousesDomain();
        
        return services;
    }
}