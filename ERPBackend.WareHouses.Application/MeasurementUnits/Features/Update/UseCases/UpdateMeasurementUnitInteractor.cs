namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Update.UseCases;

internal sealed class UpdateMeasurementUnitInteractor(
    IUpdateMeasurementUnitRepository updateRepository,
    IWareHouseUnitOfWork unitOfWork,
    IGetByIdMeasurementUnitRepository getByIdRepository,
    IUpdateMeasurementUnitOutputPort presenter,
    IExistByPrefixMeasurementUnitService existByPrefixMeasurementUnitService,
    IExistByNameMeasurementUnitService existByNameMeasurementUnitService,
    IModelValidatorHub<UpdateMeasurementUnitPayloadDto> updateMeasurementUnitValidator) : IUpdateMeasurmentUnitInputPort
{
    public async Task HandleAsync(UpdateMeasurementUnitPayloadDto payload)
    {
        if (!await updateMeasurementUnitValidator.Validate(payload))
            throw new ValidationException(updateMeasurementUnitValidator.Errors);

        var measurementUnit = await getByIdRepository.HandleAsync(new MeasurementUnitId(payload.Id));

        if (measurementUnit is null) throw new MeasurementUnitNotFoundException();

        await existByNameMeasurementUnitService.HandleAsync(measurementUnit);

        await existByPrefixMeasurementUnitService.HandleAsync(measurementUnit);

        measurementUnit.Update(payload.Name, payload.Prefix, payload.Description);

        updateRepository.Handle(measurementUnit);

        await unitOfWork.SaveChangesAsync();

        presenter.Handle(measurementUnit);
    }
}