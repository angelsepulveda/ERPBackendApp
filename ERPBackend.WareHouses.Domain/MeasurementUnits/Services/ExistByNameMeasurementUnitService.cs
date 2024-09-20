namespace ERPBackend.WareHouses.Domain.MeasurementUnits.Services;

internal sealed class ExistByNameMeasurementUnitService(IGetByNameMeasurementUnitRepository repository) : IExistByNameMeasurementUnitService 
{
    public async Task HandleAsync(MeasurementUnit measurementUnit)
    {
        var measurementUnitExist = await repository.HandleAsync(measurementUnit.Name);

        if (measurementUnitExist is not null && measurementUnit.Id.Value != measurementUnitExist.Id.Value)
            throw new MeasurementUnitAlreadyExistsException();
    }
}