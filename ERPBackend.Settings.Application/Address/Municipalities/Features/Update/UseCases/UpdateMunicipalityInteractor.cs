namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Update.UseCases;

internal sealed class UpdateMunicipalityInteractor(
    IUpdateMunicipalityRepository updateRepository,
    IUnitOfWork unitOfWork,
    IRegisterMunicipalityOutputPort presenter,
    IExitsByNameMunicipalityValidationService existByNameRegionService,
    IExitsByCodeMunicipalityValidationService existByCodeRegionService,
    IGetByIdMunicipalityRepository getByIdRepository,
    IModelValidatorHub<UpdateMunicipalityPayloadDto> updateMunicipalityValidator) : IUpdateMunicipalityInputPort
{
    public async Task HandleAsync(UpdateMunicipalityPayloadDto payload)
    {
        if (!await updateMunicipalityValidator.Validate(payload))
            throw new ValidationException(updateMunicipalityValidator.Errors);

        var municipality = await getByIdRepository.HandleAsync(new MunicipalityId(payload.Id));

        if (municipality is null) throw new CountryNotFoundException();

        municipality.Update(payload.Name, payload.Code, new CountryId(payload.CountryId),
            new RegionId(payload.RegionId));

        await existByCodeRegionService.HandleAsync(municipality);

        await existByNameRegionService.HandleAsync(municipality);

        updateRepository.Handle(municipality);

        await unitOfWork.SaveChangesAsync();

        presenter.Handle(municipality);
    }
}