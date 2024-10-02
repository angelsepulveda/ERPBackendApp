namespace ERPBackend.Settings.Application.Address.Regions.Features.Pagination.Dtos;

public sealed record PaginationRegionResponseDto(
    List<PaginationRegionDto> Data,
    int PageIndex,
    int TotalPages,
    bool HasPreviousPage,
    bool HasNextPage);