namespace ERPBackend.WareHouses.Infrastructure.Presenters.MeasurementUnits;

public static class DependencyInjection
{
    public static IServiceCollection AddMeasurementUnitsPresenters(this IServiceCollection services)
    {
        services.AddScoped<IRegisterMeasurementUnitOutputPort, RegisterMeasurementUnitPresenter>();
        services.AddScoped<IUpdateMeasurementUnitOutputPort, UpdateMeasurementUnitPresenter>();
        services.AddScoped<IPaginationMeasurementUnitOutputPort, PaginationMeasurementUnitPresenter>();
        services.AddScoped<IGetMeasurementUnitOutputPort, GetMeasurementUnitPresenter>();
        
        return services;
    }
}