namespace ERPBackend.WareHouses.Domain.MeasurementUnits.Interfaces.Repositories;

public interface IGetByNameMeasurementUnitRepository
{
    Task<MeasurementUnit?> HandleAsync(string name);
}