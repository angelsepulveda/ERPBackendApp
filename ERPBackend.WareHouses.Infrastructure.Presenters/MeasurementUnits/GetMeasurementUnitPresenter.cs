namespace ERPBackend.WareHouses.Infrastructure.Presenters.MeasurementUnits;

internal sealed class GetMeasurementUnitPresenter : IGetMeasurementUnitOutputPort
{
    public IReadOnlyList<GetMeasurementUnitResponseDto> Response { get; private set; }

    public void Handle(IReadOnlyList<MeasurementUnit> measurementUnits)
    {
        Response = measurementUnits.Select(x => new GetMeasurementUnitResponseDto(x.Id.Value, x.Name, x.Prefix))
            .ToList().AsReadOnly();
    }
}