namespace ERPBackend.WareHouses.Domain;

public static class DependencyInjection
{
    public static IServiceCollection AddWareHousesDomain(this IServiceCollection services)
    {
        services.AddCategoriesDomainServices();
        services.AddBrandsDomainServices();
        
        return services;
    }
}