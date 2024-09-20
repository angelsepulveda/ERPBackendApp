namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Pagination.Interfaces;

public interface IPaginationMeasurementUnitOutputPort
{
    PaginationMeasurementUnitResponseDto Response { get; }
    void Handle(PaginatedList<MeasurementUnit> paginatedMeasureUnits);
}