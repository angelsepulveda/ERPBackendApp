namespace ERPBackend.WareHouses.CrossCutting.IoCs;

public static class EndpointsContainer
{
    public static WebApplication UseWareHousesModuleEndpoints(this WebApplication app)
    {
        app.UseWareHousesEndpoints();
        
        return app;
    }
}