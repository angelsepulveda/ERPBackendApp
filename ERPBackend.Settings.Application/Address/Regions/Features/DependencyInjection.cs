namespace ERPBackend.Settings.Application.Address.Regions.Features;

public static class DependencyInjection
{
    public static IServiceCollection AddRegionsFeatures(this IServiceCollection services)
    {
        services.AddScoped<IPaginationRegionInputPort, PaginationRegionInteractor>();
        services.AddScoped<IGetRegionInputPort, GetRegionInteractor>();
        services.AddScoped<IUpdateRegionInputPort, UpdateRegionInteractor>();
        services.AddScoped<IRegisterRegionInputPort, RegisterRegionInteractor>();
        services.AddScoped<IDeleteRegionInputPort, DeleteRegionInteractor>();
        services.AddScoped<IRestoreRegionInputPort, RestoreRegionInteractor>();
        
        return services;
        
    }
}