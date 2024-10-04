namespace ERPBackend.Settings.Infrastructure.APÍ.VoucherTypes;

public static class RegisterVoucherTypeEndpoints
{
    public static WebApplication UseRegisterVoucherTypeEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/voucher-types/register",
                async (IRegisterVoucherTypeInputPort inputPort, IRegisterVoucherTypeOutputPort presenter,
                    [FromBody] RegisterVoucherTypePayloadDto payload) =>
                {
                    await inputPort.HandleAsync(payload);

                    return presenter.VoucherTypeId;
                }).Produces<int>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest).WithTags("Voucher Types");

        return app;
    }
}