namespace ERPBackend.Settings.Application.Address.Countries.Features.Pagination.Dtos;

public sealed record CountryDto(Guid Id, string Name, string? Code, bool Status);