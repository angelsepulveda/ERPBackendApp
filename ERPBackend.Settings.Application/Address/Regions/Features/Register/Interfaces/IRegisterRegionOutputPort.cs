namespace ERPBackend.Settings.Application.Address.Regions.Features.Register.Interfaces;

public interface IRegisterRegionOutputPort
{
    Guid RegionId { get; }
    void Handle(Region region);
}