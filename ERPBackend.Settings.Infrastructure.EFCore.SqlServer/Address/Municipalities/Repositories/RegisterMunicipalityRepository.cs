namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Municipalities.Repositories;

internal sealed class RegisterMunicipalityRepository(SettingsApplicationDbContext dbContext)
    : IRegisterMunicipalityRepository
{
    public void Handle(Municipality municipality) => dbContext.Municipalities.Add(municipality);
}