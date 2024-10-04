namespace ERPBackend.Settings.Infrastructure.APÍ.VoucherTypes;

public static class PaginationVoucherTypeEndpoints
{
    public static WebApplication UsePaginationVoucherTypeEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/voucher-types/pagination",
                async (IPaginationVoucherTypeInputPort inputPort, IPaginationVoucherTypeOutputPort presenter,
                    [FromBody] PaginationVoucherTypePayloadDto payload) =>
                {
                    await inputPort.HandleAsync(payload);

                    return presenter.PaginationResponse;
                }).Produces<PaginationVoucherTypeResponseDto>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest).WithTags("Voucher Types");

        return app;
    }
}