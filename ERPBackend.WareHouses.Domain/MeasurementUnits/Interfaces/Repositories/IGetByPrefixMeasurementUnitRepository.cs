namespace ERPBackend.WareHouses.Domain.MeasurementUnits.Interfaces.Repositories;

public interface IGetByPrefixMeasurementUnitRepository
{
    Task<MeasurementUnit?> HandleAsync(string prefix);
}