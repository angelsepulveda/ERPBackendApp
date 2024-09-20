namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.MeasurementUnits.Repositories;

public static class DependencyInjection
{
    public static IServiceCollection AddMeasurementUnitsRepositories(this IServiceCollection services)
    {
        services.AddScoped<IRegisterMeasurementUnitRepository, RegisterMeasurementUnitRepository>();
        services.AddScoped<IUpdateMeasurementUnitRepository, UpdateMeasurementUnitRepository>();
        services.AddScoped<IPaginationMeasurementUnitRepository, PaginationMeasurementUnitRepository>();
        services.AddScoped<IGetMeasurementUnitRepository, GetMeasurementUnitRepository>();
        services.AddScoped<IGetByIdMeasurementUnitRepository, GetByIdMeasurementUnitRepository>();
        services.AddScoped<IGetByPrefixMeasurementUnitRepository, GetByPrefixMeasurementUnitRepository>();
        services.AddScoped<IGetByNameMeasurementUnitRepository, GetByNameMeasurementUnitRepository>();
        
        return services;
    }
}