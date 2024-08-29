namespace ERPBackend.Settings.Domain.VoucherTypes.Interfaces.Repositories;

public interface IGetByIdVoucherTypeRepository
{
    Task<VoucherType?> HandleAsync(VoucherTypeId id);
}