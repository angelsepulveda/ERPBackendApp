namespace ERPBackend.WareHouses.Domain.Brands.Interfaces.Repositories;

public interface IGetByNameBrandRepository
{
    Task<Brand?> HandleAsync(string name);
}