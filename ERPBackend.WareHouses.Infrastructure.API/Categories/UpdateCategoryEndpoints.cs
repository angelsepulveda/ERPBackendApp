namespace ERPBackend.WareHouses.Infrastructure.API.Categories;

public static class UpdateCategoryEndpoints
{
    public static WebApplication UseUpdateCategoryEndpoint(this WebApplication app)
    {
        app.MapPut("api/v1/categories/update",
                async (IUpdateCategoryInputPort inputPort, IUpdateCategoryOutputPort presenter,
                    [FromBody] UpdateCategoryPayloadDto dto) =>
                {
                    await inputPort.HandleAsync(dto);

                    var result = presenter.Response;

                    return TypedResults.Ok(result);
                    
                }).Produces<UpdateCategoryResponseDto>(StatusCodes.Status200OK)
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest)
            .Produces<ProblemDetails>(StatusCodes.Status404NotFound).WithTags("Categories");
        return app;
    }
}