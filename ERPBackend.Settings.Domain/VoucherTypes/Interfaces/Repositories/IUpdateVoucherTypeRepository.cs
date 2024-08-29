namespace ERPBackend.Settings.Domain.VoucherTypes.Interfaces.Repositories;

public interface IUpdateVoucherTypeRepository
{
    void Handle(VoucherType voucherType);
}