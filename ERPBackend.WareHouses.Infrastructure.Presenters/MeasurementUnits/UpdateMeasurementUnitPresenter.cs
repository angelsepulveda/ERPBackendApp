namespace ERPBackend.WareHouses.Infrastructure.Presenters.MeasurementUnits;

internal sealed class UpdateMeasurementUnitPresenter : IUpdateMeasurementUnitOutputPort
{
    public UpdateMeasurementUnitResponseDto Response { get; private set; }

    public void Handle(MeasurementUnit measurementUnit)
    {
        Response = new UpdateMeasurementUnitResponseDto(measurementUnit.Id.Value, measurementUnit.Name,
            measurementUnit.Prefix, measurementUnit.Description);
    }
}