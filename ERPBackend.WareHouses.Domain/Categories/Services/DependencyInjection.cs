namespace ERPBackend.WareHouses.Domain.Categories.Services;

public static class DependencyInjection
{
    public static IServiceCollection AddCategoriesDomainServices(this IServiceCollection services)
    {
        services.AddScoped<IExistByNameCategoryService, ExistByNameCategoryService>();
        
        return services;
    }
}