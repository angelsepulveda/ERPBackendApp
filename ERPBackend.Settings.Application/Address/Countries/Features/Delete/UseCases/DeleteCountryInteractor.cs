namespace ERPBackend.Settings.Application.Address.Countries.Features.Delete.UseCases;

internal sealed class DeleteCountryInteractor( IUpdateCountryRepository updateRepository,
    IGetByIdCountryRepository getByIdRwepository,
    IUnitOfWork unitOfWork) : IDeleteCountryInputPort
{
    public async Task HandleAsync(Guid id)
    {
        var country = await getByIdRwepository.HandleAsync(new CountryId(id));

        if (country is null) throw new CountryNotFoundException();
        
        country.Delete();
        
        updateRepository.Handle(country);
        
        await unitOfWork.SaveChangesAsync();
    }
}