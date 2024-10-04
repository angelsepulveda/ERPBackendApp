namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Regions;

public static class UpdateRegionEndpoints
{
    public static WebApplication UseUpdateRegionEndpoint(this WebApplication app)
    {
        app.MapPut("api/v1/regions/update",
                async (IUpdateRegionInputPort inputPort, IUpdateRegionOutputPort presenter,
                    [FromBody] UpdateRegionPayloadDto dto) =>
                {
                    await inputPort.HandleAsync(dto);

                    var result = presenter.Response;

                    return TypedResults.Ok(result);
                }).Produces<UpdateRegionResponseDto>(StatusCodes.Status200OK)
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest)
            .Produces<ProblemDetails>(StatusCodes.Status404NotFound).WithTags("Regions");
        return app;
    }
}