namespace ERPBackend.Settings.Application.DocumentTypes.Features.GetAll.Interfaces;

public interface IGetAllDocumentTypeOutputPort
{
    IReadOnlyList<GetAllDocumentTypeResponseDto> Response { get; }
    Task ResultAsync(IReadOnlyList<DocumentType> documentTypes);
}