namespace ERPBackend.Settings.Application.Address.Regions.Features.Register.Dtos;

public sealed record RegisterRegionPayloadDto(string Name, Guid CountryId, string? Code);