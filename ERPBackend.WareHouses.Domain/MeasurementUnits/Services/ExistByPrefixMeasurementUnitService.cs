namespace ERPBackend.WareHouses.Domain.MeasurementUnits.Services;

internal sealed class ExistByPrefixMeasurementUnitService(IGetByPrefixMeasurementUnitRepository repository):  IExistByPrefixMeasurementUnitService
{
    public async Task HandleAsync(MeasurementUnit measurementUnit)
    {
        if (measurementUnit.Prefix is not null)
        {
            var measurementUnitExist = await repository.HandleAsync(measurementUnit.Prefix);

            if (measurementUnitExist is not null && measurementUnit.Id.Value != measurementUnitExist.Id.Value)
                throw new MeasurementUnitAlreadyExistsException();
        }
    }
}