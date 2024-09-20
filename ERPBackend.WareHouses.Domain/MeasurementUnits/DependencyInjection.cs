namespace ERPBackend.WareHouses.Domain.MeasurementUnits;

public static class DependencyInjection
{
    public static IServiceCollection AddMeasurementUnitsDomain(this IServiceCollection services)
    {
        services.AddMeasurementUnitsDomainServices();
        
        return services;
    }
}