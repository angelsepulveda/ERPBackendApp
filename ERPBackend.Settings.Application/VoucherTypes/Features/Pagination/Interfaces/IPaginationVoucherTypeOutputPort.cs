namespace ERPBackend.Settings.Application.VoucherTypes.Features.Pagination.Interfaces;

public interface IPaginationVoucherTypeOutputPort
{
    PaginationVoucherTypeResponseDto PaginationResponse { get; }

    void Handle(PaginatedList<VoucherType> paginatedVoucherTypes);
}