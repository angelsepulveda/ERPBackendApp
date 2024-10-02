namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Regions;

public static class RegisterRegionEndpoints
{
    public static WebApplication UseRegisterRegionEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/regions/register",
                async (IRegisterRegionInputPort inputPort, IRegisterRegionOutputPort presenter,
                    [FromBody] RegisterRegionPayloadDto payload) =>
                {
                    await inputPort.HandleAsync(payload);

                    return presenter.RegionId;
                }).Produces<int>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest);
        
        return app;
    }
}