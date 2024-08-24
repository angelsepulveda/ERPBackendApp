namespace ERPBackend.Settings.Domain.DocumentTypes.Interfaces.Repositories;

public interface IRegisterDocumentTypeRepository
{
    void Handle(DocumentType documentType);
}