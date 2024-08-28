namespace ERPBackend.Settings.Infrastructure.Presenters.DocumentTypes;

internal sealed class PaginationDocumentTypePresenter : IPaginationDocumentTypeOutputPort
{
    public PaginationDocumentTypeResponseDto PaginationResponse { get; private set; }

    public void Handle(PaginatedList<DocumentType> paginatedDocumentTypes)
    {
        var dtos = paginatedDocumentTypes.Items
            .Select(x => new DocumentTypeDto(Id: x.Id.Value, Name: x.Name, Code: x.Code, Description: x.Description,
                Status: x.Status)).ToList();

        PaginationResponse = new PaginationDocumentTypeResponseDto(Data: dtos,
            PageIndex: paginatedDocumentTypes.PageIndex, TotalPages: paginatedDocumentTypes.TotalPages,
            HasPreviousPage: paginatedDocumentTypes.HasPreviousPage, HasNextPage: paginatedDocumentTypes.HasNextPage);
    }
}