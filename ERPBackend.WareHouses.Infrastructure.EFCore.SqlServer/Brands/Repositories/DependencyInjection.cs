namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Brands.Repositories;

public static class DependencyInjection
{
    public static IServiceCollection AddBrandsRepositories(this IServiceCollection services)
    {
        services.AddScoped<IRegisterBrandRepository, RegisterBrandRepository>();
        services.AddScoped<IUpdateBrandRepository, UpdateBrandRepository>();
        services.AddScoped<IPaginationBrandRepository, PaginationBrandRepository>();
        services.AddScoped<IGetBrandRepository, GetBrandRepository>();
        services.AddScoped<IGetByIdBrandRepository, GetByIdBrandRepository>();
        services.AddScoped<IGetByNameBrandRepository, GetByNameBrandRepository>();
        
        return services;
    }
}