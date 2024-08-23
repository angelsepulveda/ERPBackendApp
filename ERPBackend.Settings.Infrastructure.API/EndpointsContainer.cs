namespace ERPBackend.Settings.Infrastructure.APÍ;

public static class EndpointsContainer
{
    public static WebApplication UseSettingsEndpoints(this WebApplication app)
    {
        app.UseDocumentTypesEndpoints();

        return app;
    }
}