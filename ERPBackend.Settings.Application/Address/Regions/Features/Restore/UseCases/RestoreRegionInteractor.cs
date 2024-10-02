namespace ERPBackend.Settings.Application.Address.Regions.Features.Restore.UseCases;

internal sealed class RestoreRegionInteractor(IGetByIdRegionRepository getByIdRepository,
    IUpdateRegionRepository updateRepository,
    IUnitOfWork unitOfWork) : IRestoreRegionInputPort
{
    public async Task HandleAsync(Guid id)
    {
        var region = await getByIdRepository.HandleAsync(new RegionId(id));

        if (region is null) throw new RegionNotFoundException();

        region.Restore();

        updateRepository.Handle(region);

        await unitOfWork.SaveChangesAsync();
    }
}