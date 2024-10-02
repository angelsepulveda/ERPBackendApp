namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Regions.Repositories;

internal sealed class RegisterRegionRepository(SettingsApplicationDbContext dbContext) : IRegisterRegionRepository
{
    public void Handle(Region region) => dbContext.Regions.Add(region);
}