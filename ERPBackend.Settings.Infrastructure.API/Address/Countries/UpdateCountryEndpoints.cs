namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Countries;

public static class UpdateCountryEndpoints
{
    public static WebApplication UseUpdateCountryEndpoint(this WebApplication app)
    {
        app.MapPut("api/v1/countries/update",
                async (IUpdateCountryInputPort inputPort, IUpdateCountryOutputPort presenter,
                    [FromBody] UpdateCountryPayloadDto dto) =>
                {
                    await inputPort.HandleAsync(dto);

                    var result = presenter.Response;

                    return TypedResults.Ok(result);
                }).Produces<UpdateCountryResponseDto>(StatusCodes.Status200OK)
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest)
            .Produces<ProblemDetails>(StatusCodes.Status404NotFound).WithTags("Countries");
        return app;
    }
    
}