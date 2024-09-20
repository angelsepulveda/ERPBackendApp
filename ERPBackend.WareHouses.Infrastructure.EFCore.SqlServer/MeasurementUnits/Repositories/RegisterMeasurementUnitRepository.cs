namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.MeasurementUnits.Repositories;

internal sealed class RegisterMeasurementUnitRepository(WareHousesApplicationDbContext dbContext)
    : IRegisterMeasurementUnitRepository
{
    public void Handle(MeasurementUnit measurementUnit) => dbContext.MeasurementUnits.Add(measurementUnit);
}