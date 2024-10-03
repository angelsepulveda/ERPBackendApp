namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Get.UseCases;

internal sealed class GetMunicipalityInteractor(
    IGetMunicipalityRepository repository,
    IGetMunicipalityOutputPort presenter) : IGetMunicipalityInputPort
{
    public async Task HandleAsync()
    {
        var municipalities = await repository.HandleAsync();

        presenter.Handle(municipalities);
    }
}