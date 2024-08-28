namespace ERPBackend.Settings.Application.DocumentTypes.Features.Pagination.Interfaces;

public interface IPaginationDocumentTypeInputPort
{
    Task HandleAsync(PaginationDocumentTypePayloadDto payload);
}