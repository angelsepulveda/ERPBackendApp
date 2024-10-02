namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Regions.Repositories;

internal sealed class GetByNameRegionRepository(SettingsApplicationDbContext dbContext) : IGetByNameRegionRepository
{
    public async Task<Region?> HandleAsync(string name) =>
        await dbContext.Regions.FirstOrDefaultAsync(x => x.Name == name);
}