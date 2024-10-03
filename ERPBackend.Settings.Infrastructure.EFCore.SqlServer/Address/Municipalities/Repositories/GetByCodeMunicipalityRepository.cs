namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Municipalities.Repositories;

internal sealed class GetByCodeMunicipalityRepository(SettingsApplicationDbContext dbContext)
    : IGetByCodeMunicipalityRepository
{
    public async Task<Municipality?> HandleAsync(string code) =>
        await dbContext.Municipalities.FirstOrDefaultAsync(m => m.Code == code);
}