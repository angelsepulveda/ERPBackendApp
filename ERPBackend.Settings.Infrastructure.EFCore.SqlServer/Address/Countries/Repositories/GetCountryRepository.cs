namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Countries.Repositories;

internal sealed class GetCountryRepository(SettingsApplicationDbContext context) : IGetCountryRepository
{
    public async Task<IReadOnlyList<Country>> HandleAsync() =>
        await context.Countries.Where(x => x.Status == true).ToListAsync();
}