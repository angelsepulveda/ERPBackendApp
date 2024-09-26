namespace ERPBackend.Settings.Application.Address.Countries.Features.Update.UseCases;

internal sealed class UpdateCountryInteractor(IUpdateCountryRepository updateRepository,
    IUnitOfWork unitOfWork,
    IGetByIdCountryRepository getByIdRepository,
    IUpdateCountryOutputPort presenter,
    IExistByCodeCountryService existByCodeService,
    IExistByNameCountryService existByNameService,
    IModelValidatorHub<UpdateCountryPayloadDto> updateCountryValidator) : IUpdateCountryInputPort
{
    public async Task HandleAsync(UpdateCountryPayloadDto payload)
    {
        if (!await updateCountryValidator.Validate(payload))
            throw new ValidationException(updateCountryValidator.Errors);
        
        var country = await getByIdRepository.HandleAsync(new CountryId(payload.Id));

        if (country is null) throw new CountryNotFoundException();
        
        country.Update(payload.Name, payload.Code);
        
        await existByCodeService.HandleAsync(country);
        
        await existByNameService.HandleAsync(country);
        
        updateRepository.Handle(country);

        await unitOfWork.SaveChangesAsync();

        presenter.Handle(country);
    }
}