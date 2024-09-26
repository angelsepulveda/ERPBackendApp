namespace ERPBackend.Settings.Application.Address.Countries.Features.Restore.UseCases;

internal sealed class RestoreCountryInteractor(
    IUpdateCountryRepository updateRepository,
    IGetByIdCountryRepository getByIdRepository,
    IUnitOfWork unitOfWork) : IRestoreCountryInputPort
{
    public async Task HandleAsync(Guid id)
    {
        var country = await getByIdRepository.HandleAsync(new CountryId(id));

        if (country is null) throw new CountryNotFoundException();

        country.Restore();

        updateRepository.Handle(country);

        await unitOfWork.SaveChangesAsync();
    }
}