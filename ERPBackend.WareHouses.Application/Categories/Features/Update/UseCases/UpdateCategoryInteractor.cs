namespace ERPBackend.WareHouses.Application.Categories.Features.Update.UseCases;

internal sealed class UpdateCategoryInteractor(
    IUpdateCategoryRepository updateRepository,
    IWareHouseUnitOfWork unitOfWork,
    IGetByIdCategoryRepository getByIdRepository,
    IUpdateCategoryOutputPort presenter,
    IExistByNameCategoryService existByNameCategoryService,
    IModelValidatorHub<UpdateCategoryPayloadDto> updateCategoryValidator) : IUpdateCategoryInputPort
{
    public async Task HandleAsync(UpdateCategoryPayloadDto payload)
    {
        if (!await updateCategoryValidator.Validate(payload))
            throw new ValidationException(updateCategoryValidator.Errors);

        var category = await getByIdRepository.HandleAsync(new CategoryId(payload.Id));

        if (category is null) throw new CategoryNotFoundException();

        await existByNameCategoryService.HandleAsync(category);

        category.Update(payload.Name, payload.Description);

        updateRepository.Handle(category);

        await unitOfWork.SaveChangesAsync();

        presenter.Handle(category);
    }
}