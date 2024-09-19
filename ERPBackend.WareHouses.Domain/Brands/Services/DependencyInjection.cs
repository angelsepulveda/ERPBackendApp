namespace ERPBackend.WareHouses.Domain.Brands.Services;

public static class DependencyInjection
{
    public static IServiceCollection AddBrandsDomainServices(this IServiceCollection services)
    {
        services.AddScoped<IExistByNameBrandService, ExistByNameBrandService>();
        
        return services;
    }
}