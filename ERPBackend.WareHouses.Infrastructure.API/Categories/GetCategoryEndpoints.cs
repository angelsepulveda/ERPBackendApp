namespace ERPBackend.WareHouses.Infrastructure.API.Categories;

public static class GetCategoryEndpoints
{
    public static WebApplication UseGetCategoryEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/categories/get",
                async (IGetCategoryInputPort inputPort, IGetCategoryOutputPort presenter) =>
                {
                    await inputPort.HandleAsync();

                    return presenter.Response;
                    
                }).Produces<IReadOnlyList<GetCategoryResponseDto>>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest);

        return app;
    }   
}