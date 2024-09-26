namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Countries.Repositories;

internal sealed class GetByNameCountryRepository(SettingsApplicationDbContext context) : IGetByNameCountryRepository
{
    public async Task<Country?> HandleAsync(string name) =>
        await context.Countries.Where(c => c.Name == name).SingleOrDefaultAsync();
}