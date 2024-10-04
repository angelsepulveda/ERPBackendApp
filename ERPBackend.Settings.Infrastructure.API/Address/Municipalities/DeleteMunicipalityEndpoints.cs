namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Municipalities;

public static class DeleteMunicipalityEndpoints
{
    public static WebApplication UseDeleteMunicipalityEndpoint(this WebApplication app)
    {
        app.MapDelete("api/v1/municipalities/delete/{id:guid}",
            async (IDeleteMunicipalityInputPort inputPort,
                Guid id) =>
            {
                await inputPort.HandleAsync(id);

                return TypedResults.NoContent();
            }).WithTags("Municipalities");
        return app;
    }
}