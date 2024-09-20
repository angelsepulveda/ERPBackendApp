namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Update.Interfaces;

public interface IUpdateMeasurmentUnitInputPort
{
    Task HandleAsync(UpdateMeasurementUnitPayloadDto payload);
}