namespace ERPBackend.WareHouses.Domain.Brands.Interfaces.Repositories;

public interface IPaginationBrandRepository
{
    Task<PaginatedList<Brand>> HandleAsync(int pageIndex, int pageSize, string? searchQuery);
}