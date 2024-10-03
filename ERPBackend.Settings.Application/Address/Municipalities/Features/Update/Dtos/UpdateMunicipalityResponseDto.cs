namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Update.Dtos;

public sealed record UpdateMunicipalityResponseDto(Guid Id, string Name, Guid CountryId, Guid RegionId, string? Code);