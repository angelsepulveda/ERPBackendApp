namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Brands;

public static class DependencyInjection
{
    public static IServiceCollection AddBrandsEFCoreSqlServer(this IServiceCollection services)
    {
        services.AddBrandsRepositories();
        
        return services;
    }
}