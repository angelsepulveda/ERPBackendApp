namespace ERPBackend.WareHouses.Domain.Categories.Interfaces.Repositories;

public interface IPaginationCategoryRepository
{
    Task<PaginatedList<Category>> HandleAsync(int pageIndex, int pageSize, string? searchQuery);
}