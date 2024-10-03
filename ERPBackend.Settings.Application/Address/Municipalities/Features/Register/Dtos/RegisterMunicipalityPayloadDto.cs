namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Register.Dtos;

public sealed record RegisterMunicipalityPayloadDto(string Name, Guid CountryId, Guid RegionId, string? Code);