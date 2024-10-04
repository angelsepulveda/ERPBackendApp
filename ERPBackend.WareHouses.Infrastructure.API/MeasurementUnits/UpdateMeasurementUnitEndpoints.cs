namespace ERPBackend.WareHouses.Infrastructure.API.MeasurementUnits;

public static class UpdateMeasurementUnitEndpoints
{
    public static WebApplication UseUpdateMeasurementUnitEndpoint(this WebApplication app)
    {
        app.MapPut("api/v1/measurement-units/update",
                async (IUpdateMeasurmentUnitInputPort inputPort, IUpdateMeasurementUnitOutputPort presenter,
                    [FromBody] UpdateMeasurementUnitPayloadDto dto) =>
                {
                    await inputPort.HandleAsync(dto);

                    var result = presenter.Response;

                    return TypedResults.Ok(result);
                    
                }).Produces<UpdateMeasurementUnitResponseDto>(StatusCodes.Status200OK)
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest)
            .Produces<ProblemDetails>(StatusCodes.Status404NotFound).WithTags("MeasurementUnits");
        return app;
    }
}