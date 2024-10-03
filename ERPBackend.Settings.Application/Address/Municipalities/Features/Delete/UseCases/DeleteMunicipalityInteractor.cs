namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Delete.UseCases;

internal sealed class DeleteMunicipalityInteractor(
    IGetByIdMunicipalityRepository getByIdRepository,
    IUnitOfWork unitOfWork,
    IUpdateMunicipalityRepository updateRepository) : IDeleteMunicipalityInputPort
{
    public async Task HandleAsync(Guid id)
    {
        var municipality = await getByIdRepository.HandleAsync(new MunicipalityId(id));

        if (municipality is null) throw new MunicipalityNotFoundException();

        municipality.Delete();

        updateRepository.Handle(municipality);

        await unitOfWork.SaveChangesAsync();
    }
}