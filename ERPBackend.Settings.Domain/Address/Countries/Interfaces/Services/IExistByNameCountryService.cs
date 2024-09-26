namespace ERPBackend.Settings.Domain.Address.Countries.Interfaces.Services;

public interface IExistByNameCountryService
{
    Task HandleAsync(Country country);
}