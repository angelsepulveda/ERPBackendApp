namespace ERPBackend.WareHouses.Infrastructure.API.Categories;

public static class RestoreCategoryEndpoints
{
    public static WebApplication UseRestoreCategoryEndpoint(this WebApplication app)
    {
        app.MapPatch("api/v1/categories/restore/{id:guid}",
            async (IRestoreCategoryInputPort inputPort,
                Guid id) =>
            {
                await inputPort.HandleAsync(id);

                return TypedResults.NoContent();
            }).Produces<int>(StatusCodes.Status204NoContent).WithTags("Categories");
        return app;
    }
}