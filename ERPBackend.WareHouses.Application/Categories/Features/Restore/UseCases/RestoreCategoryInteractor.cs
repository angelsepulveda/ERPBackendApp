namespace ERPBackend.WareHouses.Application.Categories.Features.Restore.UseCases;

internal sealed class RestoreCategoryInteractor(
    IUpdateCategoryRepository updateRepository,
    IGetByIdCategoryRepository getByIdRwepository,
    IWareHouseUnitOfWork unitOfWork) : IRestoreCategoryInputPort
{
    public async Task HandleAsync(Guid id)
    {
        var category = await getByIdRwepository.HandleAsync(new CategoryId(id));

        if (category is null) throw new CategoryNotFoundException();
        
        category.Restore();
        
        updateRepository.Handle(category);
        
        await unitOfWork.SaveChangesAsync();
    }
}