namespace ERPBackend.Settings.Application.Address.Countries.Features.Register.Interfaces;

public interface IRegisterCountryOutputPort
{
    Guid CountryId { get; }
    void Handle(Country country);
}