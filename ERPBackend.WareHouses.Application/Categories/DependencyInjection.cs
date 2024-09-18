namespace ERPBackend.WareHouses.Application.Categories;

public static class DependencyInjection
{
    public static IServiceCollection AddCategoriesApplication(this IServiceCollection services)
    {
        services.AddCategoriesFeatures();
        
        return services;
    }
}