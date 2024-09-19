namespace ERPBackend.WareHouses.Application.Brands.Features.Update.Interfaces;

public interface IUpdateBrandOutputPort
{
    UpdateBrandResponseDto Response { get; }
    void Handle(Brand brand);
}