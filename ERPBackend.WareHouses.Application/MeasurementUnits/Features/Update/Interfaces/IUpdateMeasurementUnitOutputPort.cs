namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Update.Interfaces;

public interface IUpdateMeasurementUnitOutputPort
{
    UpdateMeasurementUnitResponseDto Response { get; }
    void Handle(MeasurementUnit measurementUnit);
}