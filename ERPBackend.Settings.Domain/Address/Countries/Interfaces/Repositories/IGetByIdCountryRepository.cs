namespace ERPBackend.Settings.Domain.Address.Countries.Interfaces.Repositories;

public interface IGetByIdCountryRepository
{
    Task<Country?> HandleAsync(CountryId id);
}