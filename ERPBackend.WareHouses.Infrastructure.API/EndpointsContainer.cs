

namespace ERPBackend.WareHouses.Infrastructure.API;

public static class EndpointsContainer
{
    public static WebApplication UseWareHousesEndpoints(this WebApplication app)
    {
        app.UseCategoriesEndpoints();
        app.UseBrandsEndpoints();
        app.UseMeasurementUnitsEndpoints();
        
        return app;
    }
}