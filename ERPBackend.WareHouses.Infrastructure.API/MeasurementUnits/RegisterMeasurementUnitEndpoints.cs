namespace ERPBackend.WareHouses.Infrastructure.API.MeasurementUnits;

public static class RegisterMeasurementUnitEndpoints
{
    public static WebApplication UseRegisterMeasurementUnitEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/measurement-units/register",
                async (IRegisterMeasurementUnitInputPort inputPort, IRegisterMeasurementUnitOutputPort presenter,
                    [FromBody] RegisterMeasurementUnitPayloadDto payload) =>
                {
                    await inputPort.HandleAsync(payload);

                    return presenter.MeasurementUnitId;
                    
                }).Produces<Guid>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest);

        return app;
    }
}