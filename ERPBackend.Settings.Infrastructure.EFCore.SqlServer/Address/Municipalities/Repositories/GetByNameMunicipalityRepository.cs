namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Municipalities.Repositories;

internal sealed class GetByNameMunicipalityRepository(SettingsApplicationDbContext dbContext)
    : IGetByNameMunicipalityRepository
{
    public async Task<Municipality?> HandleAsync(string name) =>
        await dbContext.Municipalities.FirstOrDefaultAsync(m => m.Name == name);
}