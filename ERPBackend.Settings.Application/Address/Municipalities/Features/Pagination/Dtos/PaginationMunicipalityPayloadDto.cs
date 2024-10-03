namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Pagination.Dtos;

public sealed record PaginationMunicipalityPayloadDto(int PageIndex, int PageSize, string? Search);