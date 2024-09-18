namespace ERPBackend.WareHouses.Domain.Categories.Interfaces.Services;

public interface IExistByNameCategoryService
{
    Task HandleAsync(Category category);
}