namespace ERPBackend.Settings.Domain.DocumentTypes.Interfaces.Repositories;

public interface IPaginationDocumentTypeRepository
{
    Task<PaginatedList<DocumentType>> HandleAsync(int pageIndex, int pageSize);
}