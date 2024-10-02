namespace ERPBackend.Settings.Application.Address.Regions.Features.Update.Interfaces;

public interface IUpdateRegionOutputPort
{
    UpdateRegionResponseDto Response { get; }
    void Handle(Region region);
}