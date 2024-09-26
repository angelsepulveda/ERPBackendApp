namespace ERPBackend.Settings.Application.Address.Countries.Features.Pagination.Dtos;

public sealed record PaginationCountryResponseDto(
    List<CountryDto> Data,
    int PageIndex,
    int TotalPages,
    bool HasPreviousPage,
    bool HasNextPage);