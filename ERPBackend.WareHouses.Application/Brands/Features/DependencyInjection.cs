namespace ERPBackend.WareHouses.Application.Brands.Features;

public static class DependencyInjection
{
    public static IServiceCollection AddBrandsFeatures(this IServiceCollection services)
    {
        services.AddScoped<IRegisterBrandInputPort, RegisterBrandInteractor>();
        services.AddScoped<IUpdateBrandInputPort, UpdateBrandInteractor>();
        services.AddScoped<IDeleteBrandInputPort, DeleteBrandInteractor>();
        services.AddScoped<IRestoreBrandInputPort, RestoreBrandInteractor>();
        services.AddScoped<IPaginationBrandInputPort, PaginationBrandInteractor>();
        services.AddScoped<IGetBrandInputPort, GetBrandInteractor>();
        
        services.AddBrandsValidators();
        
        return services;
    }
    
    private static IServiceCollection AddBrandsValidators(this IServiceCollection services)
    {
        services.AddModelValidator<RegisterBrandPayloadDto, RegisterBrandValidator>();
        services.AddModelValidator<UpdateBrandPayloadDto, UpdateBrandValidator>();
        
        return services;
    }
}