namespace ERPBackend.WareHouses.Infrastructure.Presenters.MeasurementUnits;

internal sealed class RegisterMeasurementUnitPresenter : IRegisterMeasurementUnitOutputPort
{
    public Guid MeasurementUnitId { get; private set; }
    public void Handle(MeasurementUnit measurementUnit)
    {
        MeasurementUnitId = measurementUnit.Id.Value;
    }
}