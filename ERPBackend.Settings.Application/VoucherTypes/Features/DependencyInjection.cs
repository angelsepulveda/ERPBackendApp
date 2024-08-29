namespace ERPBackend.Settings.Application.VoucherTypes.Features;

public static class DependencyInjection
{
    public static IServiceCollection AddVoucherTypesFeatures(this IServiceCollection services)
    {
        services.AddScoped<IRegisterVoucherTypeInputPort, RegisterVoucherTypeInteractor>();
        services.AddScoped<IPaginationVoucherTypeInputPort, PaginationVoucherTypeInteractor>();
        services.AddScoped<IUpdateVoucherTypeInputPort, UpdateVoucherTypeInteractor>();
        services.AddScoped<IDeleteVoucherTypeInputPort, DeleteVoucherTypeInteractor>();
        services.AddScoped<IRestoreVoucherTypeInputPort, RestoreVoucherTypeInteractor>();
        
        services.AddVoucherTypesValidators();
        
        return services;
    }
    
    private static IServiceCollection AddVoucherTypesValidators(this IServiceCollection services)
    {
        services.AddModelValidator<RegisterVoucherTypePayloadDto, RegisterVoucherTypeValidator>();
        services.AddModelValidator<UpdateVoucherTypePayloadDto, UpdateVoucherTypeValidator>();
        
        return services;
    }
}