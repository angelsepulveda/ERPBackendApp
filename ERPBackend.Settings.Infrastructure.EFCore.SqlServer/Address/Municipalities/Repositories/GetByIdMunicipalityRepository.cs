namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Municipalities.Repositories;

internal sealed class GetByIdMunicipalityRepository(SettingsApplicationDbContext dbContext)
    : IGetByIdMunicipalityRepository
{
    public async Task<Municipality?> HandleAsync(MunicipalityId id) => await dbContext.Municipalities.FindAsync(id);
}