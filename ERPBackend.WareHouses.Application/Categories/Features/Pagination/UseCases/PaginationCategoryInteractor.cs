namespace ERPBackend.WareHouses.Application.Categories.Features.Pagination.UseCases;

internal sealed class PaginationCategoryInteractor(
    IPaginationCategoryRepository repository,
    IPaginationCategoryOutputPort presenter) : IPaginationCategoryInputPort
{
    public async Task HandleAsync(PaginationCategoryPayloadDto payloadDto)
    {
        var paginatedCategories =
            await repository.HandleAsync(payloadDto.PageIndex, payloadDto.PageSize, payloadDto.Search);

        presenter.Handle(paginatedCategories);
    }
}