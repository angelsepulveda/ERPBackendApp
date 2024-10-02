namespace ERPBackend.Settings.Application.Address.Regions.Features.Update.Dtos;

public record UpdateRegionResponseDto(Guid Id, string Name, string? Code, Guid CountryId);