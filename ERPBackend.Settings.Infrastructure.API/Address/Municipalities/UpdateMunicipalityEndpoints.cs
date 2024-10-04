namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Municipalities;

public static class UpdateMunicipalityEndpoints
{
    public static WebApplication UseUpdateMunicipalityEndpoint(this WebApplication app)
    {
        app.MapPut("api/v1/municipalities/update",
                async (IUpdateMunicipalityInputPort inputPort, IUpdateMunicipalityOutputPort presenter,
                    [FromBody] UpdateMunicipalityPayloadDto dto) =>
                {
                    await inputPort.HandleAsync(dto);

                    var result = presenter.Response;

                    return TypedResults.Ok(result);
                }).Produces<UpdateMunicipalityResponseDto>(StatusCodes.Status200OK)
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest)
            .Produces<ProblemDetails>(StatusCodes.Status404NotFound);
        return app;
    }
}