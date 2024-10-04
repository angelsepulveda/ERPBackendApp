namespace ERPBackend.Settings.Infrastructure.APÍ.DocumentTypes;

public static class GetAllDocumentTypeEndpoints
{
    public static WebApplication UseGetAllDocumentTypeEndpoint(this WebApplication app)
    {
        app.MapGet("api/v1/document-types/get-all",
            async (IGetAllDocumentTypeInputPort inputPort,IGetAllDocumentTypeOutputPort presenter) =>
            {
                await inputPort.HandleAsync();
                var result = presenter.Response;

                return TypedResults.Ok(result);
            }).WithTags("Document Types");;
        return app;
    }
}