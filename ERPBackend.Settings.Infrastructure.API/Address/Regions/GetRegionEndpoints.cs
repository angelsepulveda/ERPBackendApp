namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Regions;

public static class GetRegionEndpoints
{
    public static WebApplication UseGetRegionEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/regions/get",
                async (IGetRegionInputPort inputPort, IGetRegionOutputPort presenter) =>
                {
                    await inputPort.HandleAsync();

                    return presenter.Response;
                    
                }).Produces<IReadOnlyList<GetRegionResponseDto>>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest);

        return app;
    } 
}