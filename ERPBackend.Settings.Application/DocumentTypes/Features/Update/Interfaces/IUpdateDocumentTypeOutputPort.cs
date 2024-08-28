namespace ERPBackend.Settings.Application.DocumentTypes.Features.Update.Interfaces;

public interface IUpdateDocumentTypeOutputPort
{
    UpdateDocumentTypeResponseDto Response { get; }
    void Handle(DocumentType documentType);
}