namespace ERPBackend.Settings.Infrastructure.Presenters.Address.Regions;

internal sealed class UpdateRegionPresenter : IUpdateRegionOutputPort
{
    public UpdateRegionResponseDto Response { get; private set; }

    public void Handle(Region region)
    {
        Response = new UpdateRegionResponseDto(region.Id.Value, region.Name, region.Code, region.CountryId.Value);
    }
}