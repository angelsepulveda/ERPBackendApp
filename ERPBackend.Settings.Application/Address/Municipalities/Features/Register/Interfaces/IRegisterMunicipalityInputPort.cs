namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Register.Interfaces;

public interface IRegisterMunicipalityInputPort
{
    Task HandleAsync(RegisterMunicipalityPayloadDto payload);
}