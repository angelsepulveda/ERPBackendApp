namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Municipalities;

public static class EndpointsContainer
{
    public static WebApplication UseMunicipalitiesEndpoints(this WebApplication app)
    {
        app.UseRegisterMunicipalityEndpoint();
        app.UseGetMunicipalityEndpoint();
        app.UseDeleteMunicipalityEndpoint();
        app.UseRestoreMunicipalityEndpoint();
        app.UsePaginationMunicipalityEndpoint();
        app.UseUpdateMunicipalityEndpoint();

        return app;
    }
}