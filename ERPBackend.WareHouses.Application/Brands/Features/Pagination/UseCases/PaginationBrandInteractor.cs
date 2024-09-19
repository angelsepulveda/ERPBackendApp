namespace ERPBackend.WareHouses.Application.Brands.Features.Pagination.UseCases;

internal sealed class PaginationBrandInteractor(
    IPaginationBrandRepository repository,
    IPaginationBrandOutputPort presenter) : IPaginationBrandInputPort
{
    public async Task HandleAsync(PaginationBrandPayloadDto payloadDto)
    {
        var paginatedBrands =
            await repository.HandleAsync(payloadDto.PageIndex, payloadDto.PageSize, payloadDto.Search);

        presenter.Handle(paginatedBrands);
    }
}