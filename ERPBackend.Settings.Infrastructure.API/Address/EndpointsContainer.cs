namespace ERPBackend.Settings.Infrastructure.APÍ.Address;

public static class EndpointsContainer
{
    public static WebApplication UseAddressEndpoints(this WebApplication app)
    {
        app.UseCountriesEndpoints();
        app.UseRegionsEndpoints();
        app.UseMunicipalitiesEndpoints();
        
        return app;
    }
}