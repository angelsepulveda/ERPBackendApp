namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Register.UseCases;

internal sealed class RegisterMeasurementUnitInteractor(
    IRegisterMeasurementUnitRepository repository,
    IWareHouseUnitOfWork unitOfWork,
    IRegisterMeasurementUnitOutputPort presenter,
    IExistByPrefixMeasurementUnitService existByPrefixMeasurementUnitService,
    IExistByNameMeasurementUnitService existByNameMeasurementUnitService,
    IModelValidatorHub<RegisterMeasurementUnitPayloadDto> registerMeasurementUnitValidator) : IRegisterMeasurementUnitInputPort
{
    public async Task HandleAsync(RegisterMeasurementUnitPayloadDto payload)
    {
        if (!await registerMeasurementUnitValidator.Validate(payload))
            throw new ValidationException(registerMeasurementUnitValidator.Errors);
        
        var measurementUnit = MeasurementUnit.Create(payload.Name,payload.Prefix,payload.Description);
        
        await existByNameMeasurementUnitService.HandleAsync(measurementUnit);

        await existByPrefixMeasurementUnitService.HandleAsync(measurementUnit);

        repository.Handle(measurementUnit);

        await unitOfWork.SaveChangesAsync();

        presenter.Handle(measurementUnit);
    }
}