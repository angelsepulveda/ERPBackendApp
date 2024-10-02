namespace ERPBackend.Settings.Application.Address.Regions.Features.Register.UseCases;

internal sealed class RegisterRegionInteractor(
    IRegisterRegionRepository repository,
    IUnitOfWork unitOfWork,
    IRegisterRegionOutputPort presenter,
    IExistByNameRegionValidationSarvice existByNameRegionService,
    IExistByCodeRegionValidationService existByCodeRegionService,
    IModelValidatorHub<RegisterRegionPayloadDto> registerRegionValidator) : IRegisterRegionInputPort
{
    public async Task HandleAsync(RegisterRegionPayloadDto payload)
    {
        if (!await registerRegionValidator.Validate(payload))
            throw new ValidationException(registerRegionValidator.Errors);

        var region = Region.Create(new CountryId(payload.CountryId), payload.Name, payload.Code);

        await existByNameRegionService.HandleAsync(region);

        await existByCodeRegionService.HandleAsync(region);

        repository.Handle(region);

        await unitOfWork.SaveChangesAsync();

        presenter.Handle(region);
    }
}