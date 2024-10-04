namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Municipalities;

public static class RestoreMunicipalityEndpoints
{
    public static WebApplication UseRestoreMunicipalityEndpoint(this WebApplication app)
    {
        app.MapPatch("api/v1/municipalities/restore/{id:guid}",
            async (IRestoreMunicipalityInputPort inputPort,
                Guid id) =>
            {
                await inputPort.HandleAsync(id);

                return TypedResults.NoContent();
            }).Produces<int>(StatusCodes.Status204NoContent).WithTags("Municipalities");
        return app;
    }
}