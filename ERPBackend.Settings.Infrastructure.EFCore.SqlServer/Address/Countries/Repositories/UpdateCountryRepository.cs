namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Countries.Repositories;

internal sealed class UpdateCountryRepository(SettingsApplicationDbContext context) : IUpdateCountryRepository 
{
    public void Handle(Country country) => context.Countries.Update(country);
}