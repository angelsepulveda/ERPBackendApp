namespace ERPBackend.Settings.Infrastructure.Presenters.Address.Countries;

internal sealed class UpdateCountryPresenter : IUpdateCountryOutputPort
{
    public UpdateCountryResponseDto Response { get; private set; }

    public void Handle(Country country)
    {
        Response = new UpdateCountryResponseDto(country.Id.Value, country.Name, country.Code);
    }
}