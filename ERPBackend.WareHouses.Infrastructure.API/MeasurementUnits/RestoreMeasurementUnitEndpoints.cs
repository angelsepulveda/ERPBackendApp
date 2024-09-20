namespace ERPBackend.WareHouses.Infrastructure.API.MeasurementUnits;

public static class RestoreMeasurementUnitEndpoints
{
    public static WebApplication UseRestoreMeasurementUnitEndpoint(this WebApplication app)
    {
        app.MapPatch("api/v1/measurement-units/restore/{id:guid}",
            async (IRestoreMeasurementUnitInputPort inputPort,
                Guid id) =>
            {
                await inputPort.HandleAsync(id);

                return TypedResults.NoContent();
            }).Produces<int>(StatusCodes.Status204NoContent);
        return app;
    }
}