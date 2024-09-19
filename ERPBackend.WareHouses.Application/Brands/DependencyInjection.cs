

namespace ERPBackend.WareHouses.Application.Brands;

public static class DependencyInjection
{
    public static IServiceCollection AddBrandsApplication(this IServiceCollection services)
    {
        services.AddBrandsFeatures();
        
        return services;
    }
}