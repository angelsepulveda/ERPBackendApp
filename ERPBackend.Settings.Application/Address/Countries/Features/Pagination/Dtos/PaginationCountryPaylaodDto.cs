namespace ERPBackend.Settings.Application.Address.Countries.Features.Pagination.Dtos;

public sealed record PaginationCountryPaylaodDto(int PageIndex, int PageSize, string? Search);