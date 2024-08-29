namespace ERPBackend.Settings.Application.VoucherTypes.Features.Pagination.Dtos;

public sealed record PaginationVoucherTypeResponseDto(
    List<VoucherTypeDto> Data,
    int PageIndex,
    int TotalPages,
    bool HasPreviousPage,
    bool HasNextPage);