namespace ERPBackend.Settings.Domain.Address.Regions.Interfaces.Repositories;

public interface IPaginationRegionRepository
{
    Task<PaginatedList<RegionWithRelation>> HandleAsync(int pageIndex, int pageSize, string? searchQuery);
}