namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Restore.Interfaces;

public interface IRestoreMeasurementUnitInputPort
{
    Task HandleAsync(Guid id);
}