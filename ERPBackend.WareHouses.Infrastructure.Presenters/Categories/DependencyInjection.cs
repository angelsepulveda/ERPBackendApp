namespace ERPBackend.WareHouses.Infrastructure.Presenters.Categories;

public static class DependencyInjection
{
    public static IServiceCollection AddCategoryPresenters(this IServiceCollection services)
    {
        services.AddScoped<IRegisterCategoryOutputPort, RegisterCategoryPresenter>();
        services.AddScoped<IUpdateCategoryOutputPort, UpdateCategoryPresenter>();
        services.AddScoped<IPaginationCategoryOutputPort, PaginationCategoryPresenter>();
        services.AddScoped<IGetCategoryOutputPort, GetCategoryPresenter>();
        
        return services;
    }
}