namespace ERPBackend.Settings.Infrastructure.APÍ.VoucherTypes;

public static class UpdateVoucherTypeEndpoints
{
    public static WebApplication UseUpdateVoucherTypeEndpoint(this WebApplication app)
    {
        app.MapPut("api/v1/voucher-types/update",
                async (IUpdateVoucherTypeInputPort inputPort, IUpdateVoucherTypeOutputPort presenter,
                    [FromBody] UpdateVoucherTypePayloadDto dto) =>
                {
                    await inputPort.HandleAsync(dto);

                    var result = presenter.Response;

                    return TypedResults.Ok(result);
                }).Produces<UpdateVoucherTypeResponseDto>(StatusCodes.Status200OK)
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest)
            .Produces<ProblemDetails>(StatusCodes.Status404NotFound).WithTags("Voucher Types");;
        return app;
    }
}