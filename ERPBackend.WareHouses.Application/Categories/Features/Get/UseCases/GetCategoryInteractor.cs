namespace ERPBackend.WareHouses.Application.Categories.Features.Get.UseCases;

internal sealed class GetCategoryInteractor(IGetCategoryRepository repository, IGetCategoryOutputPort presenter)
    : IGetCategoryInputPort
{
    public async Task HandleAsync()
    {
        var categories = await repository.HandleAsync();
        
        presenter.Handle(categories);
    }
}