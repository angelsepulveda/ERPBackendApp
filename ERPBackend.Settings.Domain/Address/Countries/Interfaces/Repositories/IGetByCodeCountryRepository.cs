namespace ERPBackend.Settings.Domain.Address.Countries.Interfaces.Repositories;

public interface IGetByCodeCountryRepository
{
    Task<Country?> HandleAsync(string code);
}