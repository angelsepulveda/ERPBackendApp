namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Restore.UseCases;

internal sealed class RestoreMunicipalityInteractor(
    IGetByIdMunicipalityRepository getByIdRepository,
    IUpdateMunicipalityRepository updateRepository,
    IUnitOfWork unitOfWork) : IRestoreMunicipalityInputPort
{
    public async Task HandleAsync(Guid id)
    {
        var municipality = await getByIdRepository.HandleAsync(new MunicipalityId(id));

        if (municipality is null) throw new MunicipalityNotFoundException();

        municipality.Restore();

        updateRepository.Handle(municipality);

        await unitOfWork.SaveChangesAsync();
    }
}