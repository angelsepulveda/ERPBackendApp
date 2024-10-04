namespace ERPBackend.WareHouses.Infrastructure.API.MeasurementUnits;

public static class PaginationMeasurementUnitEndpoints
{
    public static WebApplication UsePaginationMeasurementUnitEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/measurement-units/pagination",
                async (IPaginationMeasurementUnitInputPort inputPort, IPaginationMeasurementUnitOutputPort presenter,
                    [FromBody] PaginationMeasurementUnitPayloadDto payload) =>
                {
                    await inputPort.HandleAsync(payload);

                    return presenter.Response;
                    
                }).Produces<PaginationMeasurementUnitResponseDto>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest).WithTags("MeasurementUnits");

        return app;
    }
}