namespace ERPBackend.WareHouses.Domain.MeasurementUnits.Services;

public static class DependencyInjection
{
    public static IServiceCollection AddMeasurementUnitsDomainServices(this IServiceCollection services)
    {
        services.AddScoped<IExistByNameMeasurementUnitService, ExistByNameMeasurementUnitService>();
        services.AddScoped<IExistByPrefixMeasurementUnitService, ExistByPrefixMeasurementUnitService>();
        
        return services;
    }
}