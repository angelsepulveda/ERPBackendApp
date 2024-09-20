namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Register.Interfaces;

public interface IRegisterMeasurementUnitInputPort
{
    Task HandleAsync(RegisterMeasurementUnitPayloadDto payload);
}