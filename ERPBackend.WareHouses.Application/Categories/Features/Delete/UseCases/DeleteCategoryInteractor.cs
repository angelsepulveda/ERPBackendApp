namespace ERPBackend.WareHouses.Application.Categories.Features.Delete.UseCases;

internal sealed class DeleteCategoryInteractor(  
    IUpdateCategoryRepository updateRepository,
    IGetByIdCategoryRepository getByIdRwepository,
    IWareHouseUnitOfWork unitOfWork) : IDeleteCategoryInputPort
{
    public async Task HandleAsync(Guid id)
    {
        var category = await getByIdRwepository.HandleAsync(new CategoryId(id));

        if (category is null) throw new CategoryNotFoundException();
        
        category.Delete();
        
        updateRepository.Handle(category);
        
        await unitOfWork.SaveChangesAsync();
    }
}