namespace ERPBackend.Settings.Application.VoucherTypes.Features.Pagination.Dtos;

public sealed record VoucherTypeDto(Guid Id, string Name, string? Code, string? Description, bool Status);