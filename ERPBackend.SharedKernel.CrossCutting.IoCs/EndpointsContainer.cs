namespace ERPBackend.SharedKernel.CrossCutting.IoCs;

public static class EndpointsContainer
{
    public static WebApplication UseERPEndpoints(this WebApplication app)
    {
        app.UseSettingsEndpoints();
        
        return app;
    }
}