namespace ERPBackend.Settings.Application.Address.Regions.Features.Pagination.Dtos;

public sealed record PaginationRegionDto(Guid Id, string Name, string Code, bool Status, Guid CountryId, string Country);