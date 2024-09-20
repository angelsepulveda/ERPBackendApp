namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Delete.UseCases;

internal sealed class DeleteMeasurementUnitInteractor(
    IUpdateMeasurementUnitRepository updateRepository,
    IGetByIdMeasurementUnitRepository getByIdRwepository,
    IWareHouseUnitOfWork unitOfWork) : IDeleteMeasurementUnitInputPort
{
    public async Task HandleAsync(Guid id)
    {
        var measurementUnit = await getByIdRwepository.HandleAsync(new MeasurementUnitId(id));

        if (measurementUnit is null) throw new MeasurementUnitNotFoundException();

        measurementUnit.Delete();

        updateRepository.Handle(measurementUnit);

        await unitOfWork.SaveChangesAsync();
    }
}