namespace ERPBackend.Settings.Domain.Address.Countries.Interfaces.Services;

public interface IExistByCodeCountryService
{
    Task HandleAsync(Country country);
}