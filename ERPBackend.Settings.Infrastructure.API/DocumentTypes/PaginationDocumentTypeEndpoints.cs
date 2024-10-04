namespace ERPBackend.Settings.Infrastructure.APÍ.DocumentTypes;

public static class PaginationDocumentTypeEndpoints
{
    public static WebApplication UsePaginationDocumentTypeEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/document-types/pagination",
                async (IPaginationDocumentTypeInputPort inputPort, IPaginationDocumentTypeOutputPort presenter,
                    [FromBody] PaginationDocumentTypePayloadDto payload) =>
                {
                    await inputPort.HandleAsync(payload);

                    return presenter.PaginationResponse;
                }).Produces<PaginationDocumentTypeResponseDto>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest).WithTags("Document Types");

        return app;
    }
}