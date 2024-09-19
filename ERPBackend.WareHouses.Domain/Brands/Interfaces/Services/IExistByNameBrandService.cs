namespace ERPBackend.WareHouses.Domain.Brands.Interfaces.Services;

public interface IExistByNameBrandService
{
    Task HandleAsync(Brand brand);
}