namespace ERPBackend.WareHouses.Domain.Categories.Interfaces.Repositories;

public interface IUpdateCategoryRepository
{
    void Handle(Category category);
}