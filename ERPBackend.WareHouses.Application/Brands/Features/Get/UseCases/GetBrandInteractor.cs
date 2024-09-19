namespace ERPBackend.WareHouses.Application.Brands.Features.Get.UseCases;

internal sealed class GetBrandInteractor(IGetBrandRepository repository, IGetBrandOutputPort presenter)
    : IGetBrandInputPort
{
    public async Task HandleAsync()
    {
        var brands = await repository.HandleAsync();
        
        presenter.Handle(brands);
    }
}