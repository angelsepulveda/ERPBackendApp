namespace ERPBackend.WareHouses.Application.Brands.Features.Delete.Interfaces;

public interface IDeleteBrandInputPort
{
    Task HandleAsync(Guid id);
}