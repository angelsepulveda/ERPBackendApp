namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Municipalities.Repositories;

internal sealed class UpdateMunicipalityRepository(SettingsApplicationDbContext dbContext)
    : IUpdateMunicipalityRepository
{
    public void Handle(Municipality municipality) => dbContext.Municipalities.Update(municipality);
}