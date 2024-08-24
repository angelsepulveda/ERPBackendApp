namespace ERPBackend.Settings.Domain.DocumentTypes.Interfaces.Repositories;

public interface IUpdateDocumentTypeRepository
{
    void Handle(DocumentType documentType);
}