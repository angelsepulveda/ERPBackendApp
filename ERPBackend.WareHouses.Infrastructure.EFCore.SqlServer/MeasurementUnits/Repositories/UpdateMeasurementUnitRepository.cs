namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.MeasurementUnits.Repositories;

internal sealed class UpdateMeasurementUnitRepository(WareHousesApplicationDbContext dbContext) : IUpdateMeasurementUnitRepository
{
    public void Handle(MeasurementUnit measurementUnit) => dbContext.MeasurementUnits.Update(measurementUnit);
}