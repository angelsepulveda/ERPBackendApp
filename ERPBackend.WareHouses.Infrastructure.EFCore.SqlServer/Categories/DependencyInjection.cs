namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Categories;

public static class DependencyInjection
{
    public static IServiceCollection AddCategoriesEFCoreSqlServer(this IServiceCollection services)
    {
        services.AddCategoriesRepositories();
        
        return services;
    }
}