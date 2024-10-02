namespace ERPBackend.Settings.Application.Address.Regions.Features.Get.Dtos;

public sealed record GetRegionResponseDto(Guid Id, string Name, Guid CountryId);