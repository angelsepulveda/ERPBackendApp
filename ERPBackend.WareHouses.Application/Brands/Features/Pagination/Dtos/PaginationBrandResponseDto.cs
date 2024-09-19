namespace ERPBackend.WareHouses.Application.Brands.Features.Pagination.Dtos;

public sealed record PaginationBrandResponseDto(
    List<BrandDto> Data,
    int PageIndex,
    int TotalPages,
    bool HasPreviousPage,
    bool HasNextPage);