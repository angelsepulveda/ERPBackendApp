namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Countries;

public static class DeleteCountryEndpoints
{
    public static WebApplication UseDeleteCountryEndpoint(this WebApplication app)
    {
        app.MapDelete("api/v1/countries/delete/{id:guid}",
            async (IDeleteCountryInputPort inputPort,
                Guid id) =>
            {
                await inputPort.HandleAsync(id);

                return TypedResults.NoContent();
            }).WithTags("Countries");
        return app;
    }
}