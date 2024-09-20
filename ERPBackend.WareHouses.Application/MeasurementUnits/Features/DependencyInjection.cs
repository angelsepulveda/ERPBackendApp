namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features;

public static class DependencyInjection
{
    public static IServiceCollection AddMeasurementUnitsFeatures(this IServiceCollection services)
    {
        services.AddScoped<IRegisterMeasurementUnitInputPort, RegisterMeasurementUnitInteractor>();
        services.AddScoped<IUpdateMeasurmentUnitInputPort, UpdateMeasurementUnitInteractor>();
        services.AddScoped<IDeleteMeasurementUnitInputPort, DeleteMeasurementUnitInteractor>();
        services.AddScoped<IRestoreMeasurementUnitInputPort, RestoreMeasurementUnitInteractor>();
        services.AddScoped<IPaginationMeasurementUnitInputPort, PaginationMeasurementUnitInteractor>();
        services.AddScoped<IGetMeasurementUnitInputPort, GetMeasurementUnitInteractor>();
        
        services.AddMeasurementUnitsValidators();
        
        return services;
    }
    
    private static IServiceCollection AddMeasurementUnitsValidators(this IServiceCollection services)
    {
        services.AddModelValidator<RegisterMeasurementUnitPayloadDto, RegisterMeasurementUnitValidator>();
        services.AddModelValidator<UpdateMeasurementUnitPayloadDto, UpdateMeasurementUnitValidator>();
        
        return services;
    }
}