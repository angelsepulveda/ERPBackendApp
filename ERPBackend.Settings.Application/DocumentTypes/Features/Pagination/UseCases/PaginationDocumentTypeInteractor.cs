namespace ERPBackend.Settings.Application.DocumentTypes.Features.Pagination.UseCases;

internal sealed class PaginationDocumentTypeInteractor(
    IPaginationDocumentTypeRepository repository,
    IPaginationDocumentTypeOutputPort outputPort) : IPaginationDocumentTypeInputPort
{
    public async Task HandleAsync(PaginationDocumentTypePayloadDto payload)
    {
        var paginatedDocumentTypes = await repository.HandleAsync(payload.PageIndex, payload.PageSize, payload.Search);

        outputPort.Handle(paginatedDocumentTypes);
    }
}