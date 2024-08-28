namespace ERPBackend.Settings.Application.DocumentTypes.Features.Pagination.Dtos;

public sealed record PaginationDocumentTypeResponseDto(
    List<DocumentTypeDto> Data,
    int PageIndex,
    int TotalPages,
    bool HasPreviousPage,
    bool HasNextPage);