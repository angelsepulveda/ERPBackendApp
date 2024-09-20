namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.MeasurementUnits.Repositories;

internal sealed class GetMeasurementUnitRepository(WareHousesApplicationDbContext dbContext)
    : IGetMeasurementUnitRepository
{
    public async Task<IReadOnlyList<MeasurementUnit>> HandleAsync() =>
        await dbContext.MeasurementUnits.Where(x => x.Status == true).ToListAsync();
}