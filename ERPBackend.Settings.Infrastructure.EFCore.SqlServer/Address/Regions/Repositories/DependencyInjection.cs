namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Regions.Repositories;

public static class DependencyInjection
{
    public static IServiceCollection AddRegionsRepositories(this IServiceCollection services)
    {
        services.AddScoped<IPaginationRegionRepository, PaginationRegionRepository>();
        services.AddScoped<IRegisterRegionRepository, RegisterRegionRepository>();
        services.AddScoped<IUpdateRegionRepository, UpdateRegionRepository>();
        services.AddScoped<IGetRegionRepository, GetRegionRepository>();
        services.AddScoped<IGetByIdRegionRepository, GetByIdRegionRepository>();
        services.AddScoped<IGetByNameRegionRepository, GetByNameRegionRepository>();
        services.AddScoped<IGetByCodeRegionRepository, GetByCodeRegionRepository>();
        
        return services;
    }
}