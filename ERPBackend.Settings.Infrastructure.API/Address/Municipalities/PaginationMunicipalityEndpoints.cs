namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Municipalities;

public static class PaginationMunicipalityEndpoints
{
    public static WebApplication UsePaginationMunicipalityEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/municipalities/pagination",
                async (IPaginationMunicipalityInputPort inputPort, IPaginationMunicipalityOutputPort presenter,
                    [FromBody] PaginationMunicipalityPayloadDto payload) =>
                {
                    await inputPort.HandleAsync(payload);

                    return presenter.Response;
                    
                }).Produces<PaginationMunicipalityResponseDto>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest);

        return app;
    }
}