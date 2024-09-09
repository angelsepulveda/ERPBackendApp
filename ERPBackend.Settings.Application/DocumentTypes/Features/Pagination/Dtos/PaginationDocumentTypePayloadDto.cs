namespace ERPBackend.Settings.Application.DocumentTypes.Features.Pagination.Dtos;

public sealed record PaginationDocumentTypePayloadDto(int PageIndex, int PageSize, string? Search);