namespace ERPBackend.Settings.Application.Address.Regions.Features.Delete.UseCases;

internal sealed class DeleteRegionInteractor(
    IGetByIdRegionRepository getByIdRepository,
    IUpdateRegionRepository updateRepository,
    IUnitOfWork unitOfWork) : IDeleteRegionInputPort
{
    public async Task HandleAsync(Guid id)
    {
        var region = await getByIdRepository.HandleAsync(new RegionId(id));

        if (region is null) throw new RegionNotFoundException();

        region.Delete();

        updateRepository.Handle(region);

        await unitOfWork.SaveChangesAsync();
    }
}