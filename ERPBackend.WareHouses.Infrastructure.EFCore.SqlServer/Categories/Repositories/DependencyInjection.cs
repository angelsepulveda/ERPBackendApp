namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Categories.Repositories;

public static class DependencyInjection
{
    public static IServiceCollection AddCategoriesRepositories(this IServiceCollection services)
    {
        services.AddScoped<IRegisterCategoryRepository, RegisterCategoryRepository>();
        services.AddScoped<IUpdateCategoryRepository, UpdateCategoryRepository>();
        services.AddScoped<IPaginationCategoryRepository, PaginationCategoryRepository>();
        services.AddScoped<IGetCategoryRepository, GetCategoryRepository>();
        services.AddScoped<IGetByIdCategoryRepository, GetByIdCategoryRepository>();
        services.AddScoped<IGetByNameCategoryRepository, GetByNameCategoryRepository>();
        
        return services;
    }
}