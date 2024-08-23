namespace ERPBackend.Settings.Infrastructure.APÍ.DocumentTypes;

public static class EndpointsContainer
{
    public static WebApplication UseDocumentTypesEndpoints(this WebApplication app)
    {
        app.UseRegisterDocumentTypeEndpoint();
        
        return app;
    }
}