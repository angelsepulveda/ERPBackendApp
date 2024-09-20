namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.MeasurementUnits.Repositories;

internal sealed class GetByNameMeasurementUnitRepository(WareHousesApplicationDbContext dbContext)
    : IGetByNameMeasurementUnitRepository
{
    public async Task<MeasurementUnit?> HandleAsync(string name) =>
        await dbContext.MeasurementUnits.Where(x => x.Name == name).FirstOrDefaultAsync();
}