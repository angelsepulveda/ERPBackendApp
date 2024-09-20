namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.MeasurementUnits.Repositories;

internal sealed class GetByIdMeasurementUnitRepository(WareHousesApplicationDbContext dbContext)
    : IGetByIdMeasurementUnitRepository
{
    public async Task<MeasurementUnit?> HandleAsync(MeasurementUnitId id) =>
        await dbContext.MeasurementUnits.Where(x => x.Id == id).FirstOrDefaultAsync();
}