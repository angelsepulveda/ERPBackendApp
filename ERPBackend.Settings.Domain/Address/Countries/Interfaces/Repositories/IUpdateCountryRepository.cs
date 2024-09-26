namespace ERPBackend.Settings.Domain.Address.Countries.Interfaces.Repositories;

public interface IUpdateCountryRepository
{
    void Handle(Country country);
}