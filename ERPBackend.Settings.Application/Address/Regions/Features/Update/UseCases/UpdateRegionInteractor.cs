namespace ERPBackend.Settings.Application.Address.Regions.Features.Update.UseCases;

internal sealed class UpdateRegionInteractor(
    IUpdateRegionRepository updateRepository,
    IUnitOfWork unitOfWork,
    IRegisterRegionOutputPort presenter,
    IExistByNameRegionValidationSarvice existByNameRegionService,
    IExistByCodeRegionValidationService existByCodeRegionService,
    IGetByIdRegionRepository getByIdRepository,
    IModelValidatorHub<UpdateRegionPayloadDto> updateRegionValidator) : IUpdateRegionInputPort
{
    public async Task HandleAsync(UpdateRegionPayloadDto payloadDto)
    {
        if (!await updateRegionValidator.Validate(payloadDto))
            throw new ValidationException(updateRegionValidator.Errors);

        var region = await getByIdRepository.HandleAsync(new RegionId(payloadDto.Id));

        if (region is null) throw new CountryNotFoundException();

        region.Update(new CountryId(payloadDto.CountryId), payloadDto.Name, payloadDto.Code);

        await existByCodeRegionService.HandleAsync(region);

        await existByNameRegionService.HandleAsync(region);

        updateRepository.Handle(region);

        await unitOfWork.SaveChangesAsync();

        presenter.Handle(region);
    }
}