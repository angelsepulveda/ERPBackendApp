namespace ERPBackend.Settings.Domain.Address.Countries.Interfaces.Repositories;

public interface IGetByNameCountryRepository
{
    Task<Country?> HandleAsync(string name);
}