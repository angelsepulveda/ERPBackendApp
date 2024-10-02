namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Regions.Repositories;

internal sealed class GetByCodeRegionRepository(SettingsApplicationDbContext dbContext)
    : IGetByCodeRegionRepository
{
    public async Task<Region?> HandleAsync(string code) =>
        await dbContext.Regions.FirstOrDefaultAsync(x => x.Code == code);
}