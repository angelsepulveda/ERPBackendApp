namespace ERPBackend.Settings.Application.Address.Countries.Features.Register.UseCases;

internal sealed class RegisterCountryInteractor(IRegisterCountryRepository repository,
    IUnitOfWork unitOfWork,
    IRegisterCountryOutputPort presenter,
    IExistByNameCountryService existByNameCountryService,
    IExistByCodeCountryService existByCodeCountryService,
    IModelValidatorHub<RegisterCountryPayloadDto> registerCountryValidator) : IRegisterCountryInputPort
{
    public async Task HandleAsync(RegisterCountryPayloadDto payload)
    {
        if (!await registerCountryValidator.Validate(payload))
            throw new ValidationException(registerCountryValidator.Errors);
        
        var country = Country.Create(payload.Name, payload.Code);

        await existByNameCountryService.HandleAsync(country);
        
        await existByCodeCountryService.HandleAsync(country);
        
        repository.Handle(country);

        await unitOfWork.SaveChangesAsync();

        presenter.Handle(country);
    }
}