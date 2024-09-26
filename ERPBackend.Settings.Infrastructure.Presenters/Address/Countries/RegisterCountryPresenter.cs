namespace ERPBackend.Settings.Infrastructure.Presenters.Address.Countries;

internal sealed class RegisterCountryPresenter : IRegisterCountryOutputPort
{
    public Guid CountryId { get; private set; }
    public void Handle(Country country)
    {
        CountryId = country.Id.Value;
    }
}