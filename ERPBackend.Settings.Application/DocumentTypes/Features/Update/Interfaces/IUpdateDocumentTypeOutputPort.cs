namespace ERPBackend.Settings.Application.DocumentTypes.Features.Update.Interfaces;

public interface IUpdateDocumentTypeOutputPort
{
    IResult Result { get; }
    void Handle(Result<DocumentType, IEnumerable<ValidationError>> result);
}