namespace ERPBackend.WareHouses.Infrastructure.Presenters.Brands;

public static class DependencyInjection
{
    public static IServiceCollection AddBrandsPresenters(this IServiceCollection services)
    {
        services.AddScoped<IRegisterBrandOutputPort, RegisterBrandPresenter>();
        services.AddScoped<IUpdateBrandOutputPort, UpdateBrandPresenter>();
        services.AddScoped<IPaginationBrandOutputPort, PaginationBrandPresenter>();
        services.AddScoped<IGetBrandOutputPort, GetBrandPresenter>();
        
        return services;
    }
}