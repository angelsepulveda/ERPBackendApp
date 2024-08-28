namespace ERPBackend.Settings.Application.DocumentTypes.Features.Pagination.Interfaces;

public interface IPaginationDocumentTypeOutputPort
{
    PaginationDocumentTypeResponseDto PaginationResponse { get; }

    void Handle(PaginatedList<DocumentType> paginatedDocumentTypes);
}