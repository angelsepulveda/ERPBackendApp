namespace ERPBackend.WareHouses.Application.Categories.Features;

public static class DependencyInjection
{
    public static IServiceCollection AddCategoriesFeatures(this IServiceCollection services)
    {
        services.AddScoped<IRegisterCategoryInputPort, RegisterCategoryInteractor>();
        services.AddScoped<IUpdateCategoryInputPort, UpdateCategoryInteractor>();
        services.AddScoped<IDeleteCategoryInputPort, DeleteCategoryInteractor>();
        services.AddScoped<IRestoreCategoryInputPort, RestoreCategoryInteractor>();
        services.AddScoped<IPaginationCategoryInputPort, PaginationCategoryInteractor>();
        services.AddScoped<IGetCategoryInputPort, GetCategoryInteractor>();
        
        services.AddCategoriesValidators();
        
        return services;
    }
    
    private static IServiceCollection AddCategoriesValidators(this IServiceCollection services)
    {
        services.AddModelValidator<RegisterCategoryPayloadDto, RegisterCategoryValidator>();
        services.AddModelValidator<UpdateCategoryPayloadDto, UpdateCategoryValidator>();
        
        return services;
    }
}