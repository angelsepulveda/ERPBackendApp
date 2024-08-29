namespace ERPBackend.Settings.Domain.VoucherTypes.Interfaces.Repositories;

public interface IRegisterVoucherTypeRepository
{
    void Handle(VoucherType voucherType);
}