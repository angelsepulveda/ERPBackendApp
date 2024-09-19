namespace ERPBackend.WareHouses.Application.Brands.Features.Register.UseCases;

internal sealed class RegisterBrandInteractor(
    IRegisterBrandRepository repository,
    IWareHouseUnitOfWork unitOfWork,
    IRegisterBrandOutputPort presenter,
    IExistByNameBrandService existByNameBrandService,
    IModelValidatorHub<RegisterBrandPayloadDto> registerBrandValidator) : IRegisterBrandInputPort
{
    public async Task HandleAsync(RegisterBrandPayloadDto payload)
    {
        if (!await registerBrandValidator.Validate(payload))
            throw new ValidationException(registerBrandValidator.Errors);
        
        var brand = Brand.Create(payload.Name,payload.Description);
        
        await existByNameBrandService.HandleAsync(brand);

        repository.Handle(brand);

        await unitOfWork.SaveChangesAsync();

        presenter.Handle(brand);
    }
}