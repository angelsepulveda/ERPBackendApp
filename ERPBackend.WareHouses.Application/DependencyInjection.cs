namespace ERPBackend.WareHouses.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddWareHousesApplication(this IServiceCollection services)
    {
        services.AddCategoriesApplication();
        
        return services;
    }
}