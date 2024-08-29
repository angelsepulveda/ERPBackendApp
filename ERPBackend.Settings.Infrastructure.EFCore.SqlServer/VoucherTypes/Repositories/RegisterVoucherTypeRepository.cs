namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.VoucherTypes.Repositories;

internal sealed class RegisterVoucherTypeRepository(SettingsApplicationDbContext dbContext)
    : IRegisterVoucherTypeRepository
{
    public void Handle(VoucherType voucherType) => dbContext.VoucherTypes.Add(voucherType);
}