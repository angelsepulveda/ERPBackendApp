namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.VoucherTypes.Repositories;

internal sealed class UpdateVoucherTypeRepository(SettingsApplicationDbContext dbContext)
    : IUpdateVoucherTypeRepository
{
    public void Handle(VoucherType voucherType) => dbContext.VoucherTypes.Update(voucherType);
}