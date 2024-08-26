namespace ERPBackend.Settings.Application.DocumentTypes.Features.Register.Interfaces;

public interface IRegisterDocumentTypeOutputPort
{
    IResult Result { get; }
    void Handle(Result<DocumentType,IEnumerable<ValidationError>> result);
}