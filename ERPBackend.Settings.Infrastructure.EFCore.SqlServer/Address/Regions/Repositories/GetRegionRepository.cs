namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Regions.Repositories;

internal sealed class GetRegionRepository(SettingsApplicationDbContext dbContext) : IGetRegionRepository
{
    public async Task<IReadOnlyList<Region>> HandleAsync() =>
        await dbContext.Regions.Where(x => x.Status).ToListAsync();
}