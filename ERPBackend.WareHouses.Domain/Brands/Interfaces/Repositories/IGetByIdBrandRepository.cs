namespace ERPBackend.WareHouses.Domain.Brands.Interfaces.Repositories;

public interface IGetByIdBrandRepository
{
    Task<Brand?> HandleAsync(BrandId id);
}