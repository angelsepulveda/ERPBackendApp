namespace ERPBackend.WareHouses.Infrastructure.Presenters.Brands;

internal sealed class RegisterBrandPresenter : IRegisterBrandOutputPort
{
    public Guid BrandId { get; private set; }
    public void Handle(Brand brand)
    {
        BrandId = brand.Id.Value;
    }
}