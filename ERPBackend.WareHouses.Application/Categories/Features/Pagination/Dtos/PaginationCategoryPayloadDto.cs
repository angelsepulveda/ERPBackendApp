namespace ERPBackend.WareHouses.Application.Categories.Features.Pagination.Dtos;

public sealed record PaginationCategoryPayloadDto(int PageIndex, int PageSize, string? Search);