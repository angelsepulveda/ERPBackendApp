namespace ERPBackend.WareHouses.Domain.MeasurementUnits.Interfaces.Repositories;

public interface IGetMeasurementUnitRepository
{
    Task<IReadOnlyList<MeasurementUnit>> HandleAsync();
}