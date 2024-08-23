namespace ERPBackend.Settings.Domain.DocumentTypes.Interfaces.Repositories;

public interface IRegisterDocumentTypeRepositories
{
    void Handle(DocumentType documentType);
}