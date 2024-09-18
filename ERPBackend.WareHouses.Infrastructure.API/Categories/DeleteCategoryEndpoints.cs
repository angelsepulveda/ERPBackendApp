namespace ERPBackend.WareHouses.Infrastructure.API.Categories;

public static class DeleteCategoryEndpoints
{
    public static WebApplication UseDeleteCategoryEndpoint(this WebApplication app)
    {
        app.MapDelete("api/v1/categories/delete/{id:guid}",
            async (IDeleteCategoryInputPort inputPort,
                Guid id) =>
            {
                await inputPort.HandleAsync(id);

                return TypedResults.NoContent();
            });
        return app;
    }
}