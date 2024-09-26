namespace ERPBackend.Settings.Domain.Address.Countries.Interfaces.Repositories;

public interface IRegisterCountryRepository
{
    void Handle(Country country);
}