namespace ERPBackend.WareHouses.Domain.Categories.Interfaces.Repositories;

public interface IGetByNameCategoryRepository
{
    
    Task<Category?> HandleAsync(string name);
} 