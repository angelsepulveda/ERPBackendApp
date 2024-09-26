namespace ERPBackend.Settings.Domain.Address.Countries.Interfaces.Repositories;

public interface IGetCountryRepository
{
    Task<IReadOnlyList<Country>> HandleAsync();
}