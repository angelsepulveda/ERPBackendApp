namespace ERPBackend.WareHouses.Infrastructure.Presenters.Brands;

internal sealed class GetBrandPresenter : IGetBrandOutputPort
{
    public IReadOnlyList<GetBrandResponseDto> Response { get; private set; }
    public void Handle(IReadOnlyList<Brand> brands)
    {
        Response = brands.Select(c => new GetBrandResponseDto(c.Id.Value, c.Name)).ToList();
    }
}