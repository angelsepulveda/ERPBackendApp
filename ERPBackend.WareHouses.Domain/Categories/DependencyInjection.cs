namespace ERPBackend.WareHouses.Domain.Categories;

public static class DependencyInjection
{
    public static IServiceCollection AddCategoriesDomain(this IServiceCollection services)
    {
        services.AddCategoriesDomainServices();
        
        return services;
    }
}