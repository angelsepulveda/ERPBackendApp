namespace ERPBackend.WareHouses.Application.Brands.Features.Register.Interfaces;

public interface IRegisterBrandOutputPort
{
    Guid BrandId { get; }
    void Handle(Brand brand);
}