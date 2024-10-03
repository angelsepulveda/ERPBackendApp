namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Pagination.Dtos;

public sealed record PaginationMunicipalityResponseDto(
    List<PaginationMunicipalityDto> Data,
    int PageIndex,
    int TotalPages,
    bool HasPreviousPage,
    bool HasNextPage);