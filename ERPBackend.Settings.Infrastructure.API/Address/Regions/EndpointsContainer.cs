namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Regions;

public static class EndpointsContainer
{
    public static WebApplication UseRegionsEndpoints(this WebApplication app)
    {
        app.UseRegisterRegionEndpoint();
        app.UseGetRegionEndpoint();
        app.UseDeleteRegionEndpoint();
        app.UseRestoreRegionEndpoint();
        app.UsePaginationRegionEndpoint();
        app.UseUpdateRegionEndpoint();

        return app;
    }
}