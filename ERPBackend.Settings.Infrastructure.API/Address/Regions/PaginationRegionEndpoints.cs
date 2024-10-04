namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Regions;

public static class PaginationRegionEndpoints
{
    public static WebApplication UsePaginationRegionEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/regions/pagination",
                async (IPaginationRegionInputPort inputPort, IPaginationRegionOutputPort presenter,
                    [FromBody] PaginationRegionPayloadDto payload) =>
                {
                    await inputPort.HandleAsync(payload);

                    return presenter.Response;
                    
                }).Produces<PaginationRegionResponseDto>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest).WithTags("Regions");

        return app;
    }
}