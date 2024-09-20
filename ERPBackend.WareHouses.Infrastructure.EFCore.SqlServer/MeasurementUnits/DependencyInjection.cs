namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.MeasurementUnits;

public static class DependencyInjection
{
    public static IServiceCollection AddMeasurementUnitsEFCoreSqlServer(this IServiceCollection services)
    {
        services.AddMeasurementUnitsRepositories();
        
        return services;
    }
}