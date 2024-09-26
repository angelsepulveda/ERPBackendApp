namespace ERPBackend.Settings.Application.Address.Countries.Features.Register.Interfaces;

public interface IRegisterCountryInputPort
{
    Task HandleAsync(RegisterCountryPayloadDto payload);
}