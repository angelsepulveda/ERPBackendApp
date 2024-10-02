namespace ERPBackend.Settings.Application.Address.Regions.Features.Update.Dtos;

public sealed record UpdateRegionPayloadDto(Guid Id, string Name, string? Code, Guid CountryId);