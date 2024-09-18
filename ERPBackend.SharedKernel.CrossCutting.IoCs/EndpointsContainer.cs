namespace ERPBackend.SharedKernel.CrossCutting.IoCs;

public static class EndpointsContainer
{
    public static WebApplication UseERPEndpoints(this WebApplication app)
    {
        app.UseSettingsModuleEndpoints();
        app.UseWareHousesModuleEndpoints();
        
        return app;
    }
}