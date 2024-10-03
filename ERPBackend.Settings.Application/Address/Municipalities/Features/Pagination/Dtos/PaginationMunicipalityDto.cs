namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Pagination.Dtos;

public sealed record PaginationMunicipalityDto(
    Guid Id,
    string Name,
    string Code,
    bool Status,
    Guid CountryId,
    string Country,
    Guid RegionId,
    string Region);