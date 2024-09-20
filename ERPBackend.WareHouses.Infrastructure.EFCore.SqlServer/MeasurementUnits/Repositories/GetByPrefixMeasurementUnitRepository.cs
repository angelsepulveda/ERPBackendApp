namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.MeasurementUnits.Repositories;

internal sealed class GetByPrefixMeasurementUnitRepository(WareHousesApplicationDbContext dbContext)
    : IGetByPrefixMeasurementUnitRepository
{
    public async Task<MeasurementUnit?> HandleAsync(string prefix) =>
        await dbContext.MeasurementUnits.Where(x => x.Prefix == prefix).FirstOrDefaultAsync();
}