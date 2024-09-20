namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Update.Dtos;

public sealed record UpdateMeasurementUnitResponseDto(Guid Id, string Name, string? Prefix, string? Description);