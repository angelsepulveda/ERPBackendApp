namespace ERPBackend.WareHouses.Application.MeasurementUnits;

public static class DependencyInjection
{
    public static IServiceCollection AddMeasurementUnitsApplication(this IServiceCollection services)
    {
        services.AddMeasurementUnitsFeatures();
        
        return services;
    }
}