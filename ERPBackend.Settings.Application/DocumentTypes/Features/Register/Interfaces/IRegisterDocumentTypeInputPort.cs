namespace ERPBackend.Settings.Application.DocumentTypes.Features.Register.Interfaces;

public interface IRegisterDocumentTypeInputPort
{
    Task HandleAsync(RegisterDocumentTypePayloadDto payload);
}