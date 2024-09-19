namespace ERPBackend.WareHouses.Application.Brands.Features.Get.Interfaces;

public interface IGetBrandOutputPort
{
    IReadOnlyList<GetBrandResponseDto> Response { get; }
    void Handle(IReadOnlyList<Brand> brands);
}