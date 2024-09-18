namespace ERPBackend.WareHouses.Application.Categories.Features.Pagination.Dtos;

public sealed record PaginationCategoryResponseDto(
    List<CategoryDto> Data,
    int PageIndex,
    int TotalPages,
    bool HasPreviousPage,
    bool HasNextPage);