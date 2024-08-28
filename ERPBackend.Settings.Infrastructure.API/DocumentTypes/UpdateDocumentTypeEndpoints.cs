namespace ERPBackend.Settings.Infrastructure.APÍ.DocumentTypes;

public static class UpdateDocumentTypeEndpoints
{
    public static WebApplication UseUpdateDocumentTypeEndpoint(this WebApplication app)
    {
        app.MapPut("api/v1/document-types/update",
                async (IUpdateDocumentTypeInputPort inputPort, IUpdateDocumentTypeOutputPort presenter,
                    [FromBody] UpdateDocumentTypePayloadDto dto) =>
                {
                    await inputPort.HandleAsync(dto);

                    var result = presenter.Response;

                    return TypedResults.Ok(result);
                }).Produces<UpdateDocumentTypeResponseDto>(StatusCodes.Status200OK)
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest)
            .Produces<ProblemDetails>(StatusCodes.Status404NotFound);
        return app;
    }
}