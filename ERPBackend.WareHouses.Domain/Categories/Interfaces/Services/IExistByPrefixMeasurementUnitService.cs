namespace ERPBackend.WareHouses.Domain.Categories.Interfaces.Services;

public interface IExistByPrefixMeasurementUnitService
{
    Task HandleAsync(MeasurementUnit measurementUnit);
}