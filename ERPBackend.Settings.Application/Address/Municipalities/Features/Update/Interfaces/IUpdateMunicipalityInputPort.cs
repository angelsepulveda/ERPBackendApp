namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Update.Interfaces;

public interface IUpdateMunicipalityInputPort
{
    Task HandleAsync(UpdateMunicipalityPayloadDto payload);
}