namespace ERPBackend.WareHouses.Infrastructure.API.MeasurementUnits;

public static class EndpointsContainer
{
    public static WebApplication UseMeasurementUnitsEndpoints(this WebApplication app)
    {
        app.UseRegisterMeasurementUnitEndpoint();
        app.UseDeleteMeasurementUnitEndpoint();
        app.UseRestoreMeasurementUnitEndpoint();
        app.UsePaginationMeasurementUnitEndpoint();
        app.UseUpdateMeasurementUnitEndpoint();
        app.UseGetMeasurementUnitEndpoint();
        
        return app;
    }
}