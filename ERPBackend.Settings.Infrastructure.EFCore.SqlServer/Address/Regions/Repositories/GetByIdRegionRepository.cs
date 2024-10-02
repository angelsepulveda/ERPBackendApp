namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Regions.Repositories;

internal sealed class GetByIdRegionRepository(SettingsApplicationDbContext dbContext) : IGetByIdRegionRepository
{
    public async Task<Region?> HandleAsync(RegionId id) => await dbContext.Regions.FindAsync(id);
}