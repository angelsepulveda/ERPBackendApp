namespace ERPBackend.Settings.Infrastructure.Presenters.DocumentTypes;

internal sealed class UpdateDocumentTypePresenter : IUpdateDocumentTypeOutputPort
{
    public UpdateDocumentTypeResponseDto Response { get; private set; }

    public void Handle(DocumentType documentType)
    {
        Response = new UpdateDocumentTypeResponseDto(Id: documentType.Id.Value, Name: documentType.Name,
            Code: documentType.Code, Description: documentType.Description);
    }
}