namespace ERPBackend.Settings.Application.Address.Regions.Features.Get.UseCases;

internal sealed class GetRegionInteractor(IGetRegionRepository repository, IGetRegionOutputPort presenter)
    : IGetRegionInputPort
{
    public async Task HandleAsync()
    {
        var regions = await repository.HandleAsync();
        
        presenter.Handle(regions);
    }
}