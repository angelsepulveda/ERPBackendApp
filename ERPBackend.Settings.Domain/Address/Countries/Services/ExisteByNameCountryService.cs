namespace ERPBackend.Settings.Domain.Address.Countries.Services;

internal sealed class ExisteByNameCountryService(IGetByNameCountryRepository repository) : IExistByNameCountryService
{
    public async Task HandleAsync(Country country)
    {
        var countryExist = await repository.HandleAsync(country.Name);
        
        if(countryExist is not null && country.Id.Value != countryExist.Id.Value) 
            throw new CountryAlreadyExistsException();
    }
}