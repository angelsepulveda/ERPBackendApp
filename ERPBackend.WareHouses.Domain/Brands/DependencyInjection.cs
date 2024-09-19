namespace ERPBackend.WareHouses.Domain.Brands;

public static class DependencyInjection
{
    public static IServiceCollection AddBransDomain(this IServiceCollection services)
    {
        services.AddBrandsDomainServices();
        
        return services;
    }
}