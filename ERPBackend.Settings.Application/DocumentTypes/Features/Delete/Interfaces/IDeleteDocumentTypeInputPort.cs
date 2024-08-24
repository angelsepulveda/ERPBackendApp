namespace ERPBackend.Settings.Application.DocumentTypes.Features.Delete.Interfaces;

public interface IDeleteDocumentTypeInputPort
{
    Task HandleAsync(Guid id);
}