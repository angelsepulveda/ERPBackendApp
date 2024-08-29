namespace ERPBackend.Settings.Infrastructure.APÍ.VoucherTypes;

public static class EndpointsContainer
{
    public static WebApplication UseVoucherTypesEndpoints(this WebApplication app)
    {
        app.UseRegisterVoucherTypeEndpoint();
        app.UseDeleteVoucherTypeEndpoint();
        app.UseRestoreVoucherTypeEndpoint();
        app.UsePaginationVoucherTypeEndpoint();
        app.UseUpdateVoucherTypeEndpoint();

        return app;
    }
}