namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Get.Dtos;

public sealed record GetMeasurementUnitResponseDto(Guid Id, string Name, string? Prefix);