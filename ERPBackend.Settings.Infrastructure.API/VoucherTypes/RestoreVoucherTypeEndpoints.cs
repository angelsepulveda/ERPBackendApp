using ERPBackend.Settings.Application.VoucherTypes.Features.Restore.Interfaces;

namespace ERPBackend.Settings.Infrastructure.APÍ.VoucherTypes;

public static class RestoreVoucherTypeEndpoints
{
    public static WebApplication UseRestoreVoucherTypeEndpoint(this WebApplication app)
    {
        app.MapPatch("api/v1/voucher-types/restore/{id:guid}",
            async (IRestoreVoucherTypeInputPort inputPort,
                Guid id) =>
            {
                await inputPort.HandleAsync(id);

                return TypedResults.NoContent();
            }).Produces<int>(StatusCodes.Status204NoContent);
        return app;
    }
}