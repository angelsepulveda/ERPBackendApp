namespace ERPBackend.WareHouses.Application.Brands.Features.Restore.Interfaces;

public interface IRestoreBrandInputPort
{
    Task HandleAsync(Guid id);
}