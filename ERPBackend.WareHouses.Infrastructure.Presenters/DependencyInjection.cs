namespace ERPBackend.WareHouses.Infrastructure.Presenters;

public static class DependencyInjection
{
    public static IServiceCollection AddWareHousesPresenters(this IServiceCollection services)
    {
        services.AddCategoryPresenters();
        services.AddBrandsPresenters();
        
        return services;
    }
}