namespace ERPBackend.WareHouses.Application.Brands.Features.Pagination.Dtos;

public sealed record  PaginationBrandPayloadDto(int PageIndex, int PageSize, string? Search);