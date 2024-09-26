namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Countries.Repositories;

internal sealed class GetByCodeCountryRepository(SettingsApplicationDbContext context) : IGetByCodeCountryRepository
{
    public async Task<Country?> HandleAsync(string code) =>
        await context.Countries.Where(x => x.Code == code).FirstOrDefaultAsync();
}