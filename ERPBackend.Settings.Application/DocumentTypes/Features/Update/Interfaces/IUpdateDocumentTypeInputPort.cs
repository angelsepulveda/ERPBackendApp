namespace ERPBackend.Settings.Application.DocumentTypes.Features.Update.Interfaces;

public interface IUpdateDocumentTypeInputPort
{
    Task HandleAsync(UpdateDocumentTypePayloadDto payload);
}