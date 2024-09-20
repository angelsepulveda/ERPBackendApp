namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Pagination.Dtos;

public sealed record MeasurementUnitDto(Guid Id, string Name, string? Prefix, string? Description, bool Status);