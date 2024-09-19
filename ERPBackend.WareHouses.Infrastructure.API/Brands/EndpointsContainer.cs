namespace ERPBackend.WareHouses.Infrastructure.API.Brands;

public static class EndpointsContainer
{
    public static WebApplication UseBrandsEndpoints(this WebApplication app)
    {
        app.UseRegisterBrandEndpoint();
        app.UseDeleteBrandEndpoint();
        app.UseRestoreBrandEndpoint();
        app.UsePaginationBrandEndpoint();
        app.UseUpdateBrandEndpoint();
        app.UseGetBrandEndpoint();

        return app;
    }
}