namespace ERPBackend.Settings.Infrastructure.APÍ.DocumentTypes;

public static class RestoreDocumentTypeEndpoints
{
    public static WebApplication UseRestoreDocumentTypeEndpoint(this WebApplication app)
    {
        app.MapPatch("api/v1/document-types/restore/{id:guid}",
            async (IRestoreDocumentTypeInputPort inputPort,
                Guid id) =>
            {
                await inputPort.HandleAsync(id);

                return TypedResults.NoContent();
            }).Produces<int>(StatusCodes.Status204NoContent);
        return app;
    }
}