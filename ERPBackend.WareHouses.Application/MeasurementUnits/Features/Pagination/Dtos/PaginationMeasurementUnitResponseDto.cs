namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Pagination.Dtos;

public sealed record PaginationMeasurementUnitResponseDto(
    List<MeasurementUnitDto> Data,
    int PageIndex,
    int TotalPages,
    bool HasPreviousPage,
    bool HasNextPage);