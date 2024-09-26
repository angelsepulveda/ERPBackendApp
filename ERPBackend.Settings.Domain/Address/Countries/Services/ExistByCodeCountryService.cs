namespace ERPBackend.Settings.Domain.Address.Countries.Services;

internal sealed class ExistByCodeCountryService(IGetByNameCountryRepository repository) : IExistByCodeCountryService
{
    public async Task HandleAsync(Country country)
    {
        if (country.Code is not null)
        {
            var countryExist = await repository.HandleAsync(country.Code);

            if (countryExist is not null && countryExist.Id.Value != country.Id.Value)
                throw new CountryAlreadyExistsException();
        }
    }
}