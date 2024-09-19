namespace ERPBackend.WareHouses.Application.Brands.Features.Update.Interfaces;

public interface IUpdateBrandInputPort
{
    Task HandleAsync(UpdateBrandPayloadDto payload);
}