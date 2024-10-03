namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Get.Dtos;

public sealed record GetMunicipalityResponseDto(Guid Id, string Name, Guid RegionId, Guid CountryId);