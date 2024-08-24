namespace ERPBackend.Settings.Application.DocumentTypes.Features.GetAll.UseCases;

internal sealed class GetAllDocumentTypeInteractor(
    IGetAllDocumentTypeRepository repository,
    IGetAllDocumentTypeOutputPort presenter) : IGetAllDocumentTypeInputPort
{
    public async Task HandleAsync()
    {
        var documentTypes = await repository.HandleAsync();

        await presenter.ResultAsync(documentTypes);
    }
}