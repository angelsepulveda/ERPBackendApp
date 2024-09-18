namespace ERPBackend.WareHouses.Domain.Categories.Interfaces.Repositories;

public interface IGetCategoryRepository
{
    Task<IReadOnlyList<Category>> HandleAsync();
}