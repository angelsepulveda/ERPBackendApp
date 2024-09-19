namespace ERPBackend.WareHouses.Infrastructure.API.Brands;

public static class RestoreBrandEndpoints
{
    public static WebApplication UseRestoreBrandEndpoint(this WebApplication app)
    {
        app.MapPatch("api/v1/brands/restore/{id:guid}",
            async (IRestoreBrandInputPort inputPort,
                Guid id) =>
            {
                await inputPort.HandleAsync(id);

                return TypedResults.NoContent();
            }).Produces<int>(StatusCodes.Status204NoContent);
        return app;
    }
}