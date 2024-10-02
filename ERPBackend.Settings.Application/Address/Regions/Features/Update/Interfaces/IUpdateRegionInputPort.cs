namespace ERPBackend.Settings.Application.Address.Regions.Features.Update.Interfaces;

public interface IUpdateRegionInputPort
{
    Task HandleAsync(UpdateRegionPayloadDto payloadDto);
}