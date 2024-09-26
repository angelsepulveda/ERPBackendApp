namespace ERPBackend.Settings.Application.Address.Countries.Features.Get.UseCases;

internal sealed class GetCountryInteractor(
    IGetCountryRepository repository,
    IGetCountryOutputPort presenter) : IGetCountryInputPort
{
    public async Task HandleAsync()
    {
        var countries = await repository.HandleAsync();
        
        presenter.Handle(countries);
    }
}