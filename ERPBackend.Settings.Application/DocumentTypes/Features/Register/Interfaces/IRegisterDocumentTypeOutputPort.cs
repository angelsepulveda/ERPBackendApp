namespace ERPBackend.Settings.Application.DocumentTypes.Features.Register.Interfaces;

public interface IRegisterDocumentTypeOutputPort
{
    Guid DocumentTypeId { get; }
    Task HandleAsync(DocumentType documentType);
}