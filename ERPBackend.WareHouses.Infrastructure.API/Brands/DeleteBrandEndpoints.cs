namespace ERPBackend.WareHouses.Infrastructure.API.Brands;

public static class DeleteBrandEndpoints
{
    public static WebApplication UseDeleteBrandEndpoint(this WebApplication app)
    {
        app.MapDelete("api/v1/brands/delete/{id:guid}",
            async (IDeleteBrandInputPort inputPort,
                Guid id) =>
            {
                await inputPort.HandleAsync(id);

                return TypedResults.NoContent();
            }).WithTags("Brands");;
        return app;
    }
}