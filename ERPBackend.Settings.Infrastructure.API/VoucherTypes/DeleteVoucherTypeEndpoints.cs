namespace ERPBackend.Settings.Infrastructure.APÍ.VoucherTypes;

public static class DeleteVoucherTypeEndpoints
{
    public static WebApplication UseDeleteVoucherTypeEndpoint(this WebApplication app)
    {
        app.MapDelete("api/v1/voucher-types/delete/{id:guid}",
            async (IDeleteVoucherTypeInputPort inputPort,
                Guid id) =>
            {
                await inputPort.HandleAsync(id);

                return TypedResults.NoContent();
            }).WithTags("Voucher Types");
        return app;
    }
}