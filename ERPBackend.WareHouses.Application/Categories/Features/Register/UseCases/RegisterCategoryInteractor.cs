namespace ERPBackend.WareHouses.Application.Categories.Features.Register.UseCases;

internal sealed class RegisterCategoryInteractor(
    IRegisterCategoryRepository repository,
    IWareHouseUnitOfWork unitOfWork,
    IRegisterCategoryOutputPort presenter,
    IExistByNameCategoryService existByNameCategoryService,
    IModelValidatorHub<RegisterCategoryPayloadDto> registerCategoryValidator) : IRegisterCategoryInputPort
{
    public async Task HandleAsync(RegisterCategoryPayloadDto payload)
    {
        if (!await registerCategoryValidator.Validate(payload))
            throw new ValidationException(registerCategoryValidator.Errors);
        
        var category = Category.Create(payload.Name,payload.Description);
        
        await existByNameCategoryService.HandleAsync(category);

        repository.Handle(category);

        await unitOfWork.SaveChangesAsync();

        presenter.Handle(category);
    }
}