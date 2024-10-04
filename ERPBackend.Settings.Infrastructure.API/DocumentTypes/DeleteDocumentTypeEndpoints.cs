namespace ERPBackend.Settings.Infrastructure.APÍ.DocumentTypes;

public static class DeleteDocumentTypeEndpoints
{
    public static WebApplication UseDeleteDocumentTypeEndpoint(this WebApplication app)
    {
        app.MapDelete("api/v1/document-types/delete/{id:guid}",
            async (IDeleteDocumentTypeInputPort inputPort,
                Guid id) =>
            {
                await inputPort.HandleAsync(id);

                return TypedResults.NoContent();
            }).WithTags("Document Types");;
        return app;
    }
}