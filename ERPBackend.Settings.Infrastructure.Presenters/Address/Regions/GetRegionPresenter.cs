namespace ERPBackend.Settings.Infrastructure.Presenters.Address.Regions;

internal sealed class GetRegionPresenter : IGetRegionOutputPort
{
    public IReadOnlyList<GetRegionResponseDto> Response { get; private set; }

    public void Handle(IReadOnlyList<Region> regions)
    {
        Response = regions.Select(x => new GetRegionResponseDto(x.Id.Value, x.Name, x.CountryId.Value)).ToList();
    }
}