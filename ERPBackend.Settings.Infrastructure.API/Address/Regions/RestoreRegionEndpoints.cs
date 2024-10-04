namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Regions;

public static class RestoreRegionEndpoints
{
    public static WebApplication UseRestoreRegionEndpoint(this WebApplication app)
    {
        app.MapPatch("api/v1/regions/restore/{id:guid}",
            async (IRestoreRegionInputPort inputPort,
                Guid id) =>
            {
                await inputPort.HandleAsync(id);

                return TypedResults.NoContent();
            }).Produces<int>(StatusCodes.Status204NoContent).WithTags("Regions");
        return app;
    }
}