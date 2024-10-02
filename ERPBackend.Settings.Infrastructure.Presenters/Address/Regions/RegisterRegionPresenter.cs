namespace ERPBackend.Settings.Infrastructure.Presenters.Address.Regions;

internal sealed class RegisterRegionPresenter : IRegisterRegionOutputPort
{
    public Guid RegionId { get; private set; }
    public void Handle(Region region)
    {
        RegionId = region.Id.Value;
    }
}