namespace ERPBackend.Settings.Application.Address.Regions.Features.Pagination.UseCases;

internal sealed class PaginationRegionInteractor(
    IPaginationRegionRepository repository,
    IPaginationRegionOutputPort presenter) : IPaginationRegionInputPort
{
    public async Task HandleAsync(PaginationRegionPayloadDto payload)
    {
        var paginatedList = await repository.HandleAsync(payload.PageIndex, payload.PageSize, payload.Search);

        presenter.Handle(paginatedList);
    }
}