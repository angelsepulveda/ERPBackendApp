namespace ERPBackend.Settings.Application.Address.Regions.Features.Pagination.Dtos;

public sealed record PaginationRegionPayloadDto(int PageIndex, int PageSize, string? Search);