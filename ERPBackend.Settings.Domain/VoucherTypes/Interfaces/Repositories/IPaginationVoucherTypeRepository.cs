namespace ERPBackend.Settings.Domain.VoucherTypes.Interfaces.Repositories;

public interface IPaginationVoucherTypeRepository
{
    Task<PaginatedList<VoucherType>> HandleAsync(int pageIndex, int pageSize);
}