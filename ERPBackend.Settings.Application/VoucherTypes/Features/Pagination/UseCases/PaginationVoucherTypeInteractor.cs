namespace ERPBackend.Settings.Application.VoucherTypes.Features.Pagination.UseCases;

internal sealed class PaginationVoucherTypeInteractor(
    IPaginationVoucherTypeRepository repository,
    IPaginationVoucherTypeOutputPort outputPort) : IPaginationVoucherTypeInputPort
{
    public async Task HandleAsync(PaginationVoucherTypePayloadDto payload)
    {
        var paginatedVoucherTypes = await repository.HandleAsync(payload.PageIndex, payload.PageSize);

        outputPort.Handle(paginatedVoucherTypes);
    }
}