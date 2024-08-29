namespace ERPBackend.Settings.Application.VoucherTypes.Features.Pagination.Interfaces;

public interface IPaginationVoucherTypeInputPort
{
    Task HandleAsync(PaginationVoucherTypePayloadDto payload);
}