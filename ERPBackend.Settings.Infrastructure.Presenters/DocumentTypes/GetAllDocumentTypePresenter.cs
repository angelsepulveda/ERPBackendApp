namespace ERPBackend.Settings.Infrastructure.Presenters.DocumentTypes;

internal sealed class GetAllDocumentTypePresenter : IGetAllDocumentTypeOutputPort
{
    public IReadOnlyList<GetAllDocumentTypeResponseDto> Response { get; private set; }

    public Task ResultAsync(IReadOnlyList<DocumentType> documentTypes)
    {
        Response = documentTypes.Select(x =>
                new GetAllDocumentTypeResponseDto(x.Id.Value, x.Name, x.Code, x.Description, x.Status)).ToList()
            .AsReadOnly();
        
        return Task.CompletedTask;
    }
}