namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Get.UseCases;

internal sealed class GetMeasurementUnitInteractor(
    IGetMeasurementUnitRepository repository,
    IGetMeasurementUnitOutputPort presenter) : IGetMeasurementUnitInputPort
{
    public async Task HandleAsync()
    {
        var measurementUnits = await repository.HandleAsync();
        
        presenter.Handle(measurementUnits);
    }
}