namespace ERPBackend.WareHouses.Infrastructure.API.Categories;

public static class EndpointsContainer
{
    public static WebApplication UseCategoriesEndpoints(this WebApplication app)
    {
        app.UseRegisterCategoryEndpoint();
        app.UseDeleteCategoryEndpoint();
        app.UseRestoreCategoryEndpoint();
        app.UsePaginationCategoryEndpoint();
        app.UseUpdateCategoryEndpoint();
        app.UseGetCategoryEndpoint();

        return app;
    }
}