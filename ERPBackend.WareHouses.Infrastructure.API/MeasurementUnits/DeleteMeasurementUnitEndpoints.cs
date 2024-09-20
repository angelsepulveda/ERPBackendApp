namespace ERPBackend.WareHouses.Infrastructure.API.MeasurementUnits;

public static class DeleteMeasurementUnitEndpoints
{
    public static WebApplication UseDeleteMeasurementUnitEndpoint(this WebApplication app)
    {
        app.MapDelete("api/v1/measurement-units/delete/{id:guid}",
            async (IDeleteMeasurementUnitInputPort inputPort,
                Guid id) =>
            {
                await inputPort.HandleAsync(id);

                return TypedResults.NoContent();
            });
        return app;
    }
}