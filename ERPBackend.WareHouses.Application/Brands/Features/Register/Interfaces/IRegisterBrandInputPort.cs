namespace ERPBackend.WareHouses.Application.Brands.Features.Register.Interfaces;

public interface IRegisterBrandInputPort
{
    Task HandleAsync(RegisterBrandPayloadDto payload);
}