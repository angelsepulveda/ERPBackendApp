

namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Restore.UseCases;

internal sealed class RestoreMeasurementUnitInteractor(
    IUpdateMeasurementUnitRepository updateRepository,
    IGetByIdMeasurementUnitRepository getByIdRwepository,
    IWareHouseUnitOfWork unitOfWork
): IRestoreMeasurementUnitInputPort
{
    public async Task HandleAsync(Guid id)
    {
        var measurementUnit = await getByIdRwepository.HandleAsync(new MeasurementUnitId(id));

        if (measurementUnit is null) throw new MeasurementUnitNotFoundException();
        
        measurementUnit.Restore();
        
        updateRepository.Handle(measurementUnit);
        
        await unitOfWork.SaveChangesAsync();
    }
}