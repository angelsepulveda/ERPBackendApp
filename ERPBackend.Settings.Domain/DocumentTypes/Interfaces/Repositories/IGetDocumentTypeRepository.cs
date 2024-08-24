namespace ERPBackend.Settings.Domain.DocumentTypes.Interfaces.Repositories;

public interface IGetDocumentTypeRepository
{
    Task<IReadOnlyList<DocumentType>> HandleAsync();
}