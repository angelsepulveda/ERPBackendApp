namespace ERPBackend.WareHouses.Infrastructure.API.Categories;

public static class PaginationCategoryEndpoints
{
    public static WebApplication UsePaginationCategoryEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/categories/pagination",
                async (IPaginationCategoryInputPort inputPort, IPaginationCategoryOutputPort presenter,
                    [FromBody] PaginationCategoryPayloadDto payload) =>
                {
                    await inputPort.HandleAsync(payload);

                    return presenter.ResponseDto;
                    
                }).Produces<PaginationCategoryResponseDto>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest).WithTags("Categories");

        return app;
    }
}