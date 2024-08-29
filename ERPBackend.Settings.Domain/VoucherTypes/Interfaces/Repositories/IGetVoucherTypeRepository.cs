namespace ERPBackend.Settings.Domain.VoucherTypes.Interfaces.Repositories;

public interface IGetVoucherTypeRepository
{
    Task<IReadOnlyList<VoucherType>> HandleAsync();
}