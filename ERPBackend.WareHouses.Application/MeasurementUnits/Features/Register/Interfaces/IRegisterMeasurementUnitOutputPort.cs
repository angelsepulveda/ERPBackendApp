namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Register.Interfaces;

public interface IRegisterMeasurementUnitOutputPort
{
    Guid MeasurementUnitId { get; }
    void Handle(MeasurementUnit measurementUnit);
}