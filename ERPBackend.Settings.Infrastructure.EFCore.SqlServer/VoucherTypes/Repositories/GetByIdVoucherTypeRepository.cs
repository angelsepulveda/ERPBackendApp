namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.VoucherTypes.Repositories;

internal sealed class GetByIdVoucherTypeRepository(SettingsApplicationDbContext dbContext)
    : IGetByIdVoucherTypeRepository
{
    public async Task<VoucherType?> HandleAsync(VoucherTypeId id) =>
        await dbContext.VoucherTypes.Where(x => x.Id == id).FirstOrDefaultAsync();
}