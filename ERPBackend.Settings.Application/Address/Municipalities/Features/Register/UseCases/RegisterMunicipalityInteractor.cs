namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Register.UseCases;

internal sealed class RegisterMunicipalityInteractor(
    IRegisterMunicipalityRepository repository,
    IUnitOfWork unitOfWork,
    IRegisterMunicipalityOutputPort presenter,
    IExitsByNameMunicipalityValidationService existByNameMunicipalityService,
    IExitsByCodeMunicipalityValidationService existByCodeMunicipalityService,
    IModelValidatorHub<RegisterMunicipalityPayloadDto> registerMunicipalityValidator) : IRegisterMunicipalityInputPort
{
    public async Task HandleAsync(RegisterMunicipalityPayloadDto payload)
    {
        if (!await registerMunicipalityValidator.Validate(payload))
            throw new ValidationException(registerMunicipalityValidator.Errors);

        var municipality = Municipality.Create(payload.Name, payload.Code, new CountryId(payload.CountryId),
            new RegionId(payload.RegionId));

        await existByNameMunicipalityService.HandleAsync(municipality);

        await existByCodeMunicipalityService.HandleAsync(municipality);

        repository.Handle(municipality);

        await unitOfWork.SaveChangesAsync();

        presenter.Handle(municipality);
    }
}