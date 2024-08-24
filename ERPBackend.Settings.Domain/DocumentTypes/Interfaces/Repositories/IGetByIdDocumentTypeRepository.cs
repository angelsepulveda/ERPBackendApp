namespace ERPBackend.Settings.Domain.DocumentTypes.Interfaces.Repositories;

public interface IGetByIdDocumentTypeRepository
{
    Task<DocumentType?> HandleAsync(DocumentTypeId id);
}