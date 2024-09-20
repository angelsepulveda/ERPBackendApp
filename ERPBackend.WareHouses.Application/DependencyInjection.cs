namespace ERPBackend.WareHouses.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddWareHousesApplication(this IServiceCollection services)
    {
        services.AddCategoriesApplication();
        services.AddBrandsApplication();
        services.AddMeasurementUnitsApplication();
        
        return services;
    }
}