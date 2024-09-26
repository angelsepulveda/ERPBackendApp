namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Countries;

public static class EndpointsContainer
{
    public static WebApplication UseCountriesEndpoints(this WebApplication app)
    {
        app.UseRegisterCountryEndpoint();
        app.UseGetCountryEndpoint();
        app.UseDeleteCountryEndpoint();
        app.UseRestoreCountryEndpoint();
        app.UsePaginationCountryEndpoint();
        app.UseUpdateCountryEndpoint();

        return app;
    }
}