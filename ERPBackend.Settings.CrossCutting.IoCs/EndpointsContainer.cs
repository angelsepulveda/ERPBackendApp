using Microsoft.AspNetCore.Builder;

namespace ERPBackend.Settings.CrossCutting.IoCs;

public static class EndpointsContainer
{
    public static WebApplication UseSettingsModuleEndpoints(this WebApplication app)
    {
        app.UseSettingsEndpoints();
        
        return app;
    }
}