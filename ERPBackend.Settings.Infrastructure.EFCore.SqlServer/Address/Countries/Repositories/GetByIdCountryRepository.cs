namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Countries.Repositories;

internal sealed class GetByIdCountryRepository(SettingsApplicationDbContext context) : IGetByIdCountryRepository 
{
    public async Task<Country?> HandleAsync(CountryId id) => await context.Countries.FindAsync(id);
}