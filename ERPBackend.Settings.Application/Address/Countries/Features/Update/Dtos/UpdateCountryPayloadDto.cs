namespace ERPBackend.Settings.Application.Address.Countries.Features.Update.Dtos;

public sealed record UpdateCountryPayloadDto(Guid Id, string Name, string? Code);