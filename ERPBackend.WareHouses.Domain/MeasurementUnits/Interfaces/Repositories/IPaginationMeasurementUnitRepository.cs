namespace ERPBackend.WareHouses.Domain.MeasurementUnits.Interfaces.Repositories;

public interface IPaginationMeasurementUnitRepository
{
    Task<PaginatedList<MeasurementUnit>> HandleAsync(int pageIndex, int pageSize, string? searchQuery);
}