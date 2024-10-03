namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Municipalities.Repositories;

internal sealed class GetMunicipalityRepository(SettingsApplicationDbContext dbContext) : IGetMunicipalityRepository
{
    public async Task<IReadOnlyList<Municipality>> HandleAsync() =>
        await dbContext.Municipalities.Where(x => x.Status).ToListAsync();
}