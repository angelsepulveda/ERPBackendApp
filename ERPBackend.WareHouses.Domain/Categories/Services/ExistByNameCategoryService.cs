namespace ERPBackend.WareHouses.Domain.Categories.Services;

internal sealed class ExistByNameCategoryService(IGetByNameCategoryRepository repository) : IExistByNameCategoryService
{
    public async Task HandleAsync(Category category)
    {
        var categoryExist = await repository.HandleAsync(category.Name);
        
        if(categoryExist is not null && category.Id.Value != categoryExist.Id.Value) 
            throw new CategoryAlreadyExistsException();
    }
}