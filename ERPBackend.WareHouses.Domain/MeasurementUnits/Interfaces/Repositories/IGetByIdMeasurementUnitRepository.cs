namespace ERPBackend.WareHouses.Domain.MeasurementUnits.Interfaces.Repositories;

public interface IGetByIdMeasurementUnitRepository
{
    Task<MeasurementUnit?> HandleAsync(MeasurementUnitId id);
}