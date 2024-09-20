namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Delete.Interfaces;

public interface IDeleteMeasurementUnitInputPort
{
    Task HandleAsync(Guid id);
}