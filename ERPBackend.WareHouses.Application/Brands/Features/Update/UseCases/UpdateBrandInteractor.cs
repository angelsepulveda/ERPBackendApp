namespace ERPBackend.WareHouses.Application.Brands.Features.Update.UseCases;

internal sealed class UpdateBrandInteractor(
    IUpdateBrandRepository updateRepository,
    IWareHouseUnitOfWork unitOfWork,
    IGetByIdBrandRepository getByIdRepository,
    IUpdateBrandOutputPort presenter,
    IExistByNameBrandService existByNameBrandService,
    IModelValidatorHub<UpdateBrandPayloadDto> updateBrandValidator) : IUpdateBrandInputPort
{
    public async Task HandleAsync(UpdateBrandPayloadDto payload)
    {
        if (!await updateBrandValidator.Validate(payload))
            throw new ValidationException(updateBrandValidator.Errors);

        var brand = await getByIdRepository.HandleAsync(new BrandId(payload.Id));

        if (brand is null) throw new BrandNotFoundException();

        await existByNameBrandService.HandleAsync(brand);

        brand.Update(payload.Name, payload.Description);

        updateRepository.Handle(brand);

        await unitOfWork.SaveChangesAsync();

        presenter.Handle(brand);
    }
}