namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Regions.Repositories;

internal sealed class UpdateRegionRepository(SettingsApplicationDbContext dbContext) : IUpdateRegionRepository
{
    public void Handle(Region region) => dbContext.Regions.Update(region);
}