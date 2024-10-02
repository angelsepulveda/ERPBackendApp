namespace ERPBackend.Settings.Application.Address.Regions.Features.Register.Interfaces;

public interface IRegisterRegionInputPort
{
    Task HandleAsync(RegisterRegionPayloadDto payload);
}