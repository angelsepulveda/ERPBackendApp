namespace ERPBackend.Settings.Infrastructure.Presenters.Address.Regions;

public static class DependencyInjection
{
    public static IServiceCollection AddRegionsPresenter(this IServiceCollection services)
    {
        services.AddScoped<IPaginationRegionOutputPort, PaginationRegionPresenter>();
        services.AddScoped<IGetRegionOutputPort, GetRegionPresenter>();
        services.AddScoped<IUpdateRegionOutputPort, UpdateRegionPresenter>();
        services.AddScoped<IRegisterRegionOutputPort, RegisterRegionPresenter>();
        
        return services;
    }
}