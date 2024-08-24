namespace ERPBackend.Settings.Domain.DocumentTypes.Interfaces.Repositories;

public interface IGetAllDocumentTypeRepository
{
    Task<IReadOnlyList<DocumentType>> HandleAsync();
}