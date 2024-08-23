namespace ERPBackend.Settings.Infrastructure.APÍ.DocumentTypes;

public static class RegisterDocumentTypeEndpoints
{
    public static WebApplication UseRegisterDocumentTypeEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/document-types/register",
            async (IRegisterDocumentTypeInputPort inputPort, IRegisterDocumentTypeOutputPort presenter,
                [FromBody] RegisterDocumentTypePayloadDto payload) =>
            {
                await inputPort.HandleAsync(payload);
                var result = presenter.DocumentTypeId;

                return TypedResults.Ok(result);
            });
        return app;
    }
}