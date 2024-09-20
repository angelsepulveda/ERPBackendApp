namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Get.Interfaces;

public interface IGetMeasurementUnitOutputPort
{
    IReadOnlyList<GetMeasurementUnitResponseDto> Response { get; }
    void Handle(IReadOnlyList<MeasurementUnit> measurementUnits);
}