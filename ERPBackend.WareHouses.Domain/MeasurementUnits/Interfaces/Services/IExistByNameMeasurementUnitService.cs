namespace ERPBackend.WareHouses.Domain.MeasurementUnits.Interfaces.Services;

public interface IExistByNameMeasurementUnitService
{
    Task HandleAsync(MeasurementUnit measurementUnit);
}