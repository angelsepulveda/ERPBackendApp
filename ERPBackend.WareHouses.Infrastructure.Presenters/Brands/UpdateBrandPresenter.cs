namespace ERPBackend.WareHouses.Infrastructure.Presenters.Brands;

internal sealed class UpdateBrandPresenter : IUpdateBrandOutputPort
{
    public UpdateBrandResponseDto Response { get; private set; }
    public void Handle(Brand brand)
    {
        Response = new UpdateBrandResponseDto(brand.Id.Value, brand.Name, brand.Description);
    }
}