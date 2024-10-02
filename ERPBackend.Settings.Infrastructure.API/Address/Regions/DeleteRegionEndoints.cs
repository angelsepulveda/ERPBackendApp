namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Regions;

public static class DeleteRegionEndoints
{
    public static WebApplication UseDeleteRegionEndpoint(this WebApplication app)
    {
        app.MapDelete("api/v1/regions/delete/{id:guid}",
            async (IDeleteRegionInputPort inputPort,
                Guid id) =>
            {
                await inputPort.HandleAsync(id);

                return TypedResults.NoContent();
            });
        return app;
    }
}