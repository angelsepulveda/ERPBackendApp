namespace ERPBackend.WareHouses.Domain.Categories.Interfaces.Repositories;

public interface IGetByIdCategoryRepository
{
    Task<Category?> HandleAsync(CategoryId id);
}