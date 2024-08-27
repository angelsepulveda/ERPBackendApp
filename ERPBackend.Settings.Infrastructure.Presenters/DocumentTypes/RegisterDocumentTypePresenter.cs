namespace ERPBackend.Settings.Infrastructure.Presenters.DocumentTypes;

internal sealed class RegisterDocumentTypePresenter : IRegisterDocumentTypeOutputPort
{
    public Guid DocumentTypeId { get; private set; }

    public void Handle(DocumentType documentType)
    {
        DocumentTypeId = documentType.Id.Value;
    }
}