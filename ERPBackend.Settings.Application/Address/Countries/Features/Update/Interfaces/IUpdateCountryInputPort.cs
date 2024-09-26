namespace ERPBackend.Settings.Application.Address.Countries.Features.Update.Interfaces;

public interface IUpdateCountryInputPort
{
    Task HandleAsync(UpdateCountryPayloadDto payload);
}