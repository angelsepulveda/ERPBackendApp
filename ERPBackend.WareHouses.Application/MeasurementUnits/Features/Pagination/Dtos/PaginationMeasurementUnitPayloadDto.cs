namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Pagination.Dtos;

public sealed record PaginationMeasurementUnitPayloadDto(int PageIndex, int PageSize, string? Search);