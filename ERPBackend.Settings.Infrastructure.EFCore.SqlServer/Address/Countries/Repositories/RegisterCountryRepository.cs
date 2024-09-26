namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Countries.Repositories;

internal sealed class RegisterCountryRepository(SettingsApplicationDbContext context) : IRegisterCountryRepository 
{
    public void Handle(Country country) => context.Countries.Add(country);
}