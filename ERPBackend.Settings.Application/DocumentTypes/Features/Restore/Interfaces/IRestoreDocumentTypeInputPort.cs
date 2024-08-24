namespace ERPBackend.Settings.Application.DocumentTypes.Features.Restore.Interfaces;

public interface IRestoreDocumentTypeInputPort
{
    Task HandleAsync(Guid id);
}