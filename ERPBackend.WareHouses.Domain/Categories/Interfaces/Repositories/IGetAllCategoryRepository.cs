namespace ERPBackend.WareHouses.Domain.Categories.Interfaces.Repositories;

public interface IGetAllCategoryRepository
{
    Task<IReadOnlyList<Category>> HandleAsync();
}