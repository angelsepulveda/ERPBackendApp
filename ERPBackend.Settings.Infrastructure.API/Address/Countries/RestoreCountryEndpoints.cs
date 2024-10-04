namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Countries;

public static class RestoreCountryEndpoints
{
    public static WebApplication UseRestoreCountryEndpoint(this WebApplication app)
    {
        app.MapPatch("api/v1/countries/restore/{id:guid}",
            async (IRestoreCountryInputPort inputPort,
                Guid id) =>
            {
                await inputPort.HandleAsync(id);

                return TypedResults.NoContent();
            }).Produces<int>(StatusCodes.Status204NoContent).WithTags("Countries");
        return app;
    }
}