namespace ERPBackend.WareHouses.Domain.Brands.Interfaces.Repositories;

public interface IGetBrandRepository
{
    Task<IReadOnlyList<Brand>> HandleAsync();
}