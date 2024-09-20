namespace ERPBackend.WareHouses.Infrastructure.API.MeasurementUnits;

public static class GetMeasurementUnitEndpoints
{
    public static WebApplication UseGetMeasurementUnitEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/measurement-units/get",
                async (IGetMeasurementUnitInputPort inputPort, IGetMeasurementUnitOutputPort presenter) =>
                {
                    await inputPort.HandleAsync();

                    return presenter.Response;
                    
                }).Produces<IReadOnlyList<GetMeasurementUnitResponseDto>>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest);
        
        return app;
    } 
}