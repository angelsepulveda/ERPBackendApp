namespace ERPBackend.Settings.Application.DocumentTypes.Features.Pagination.Dtos;

public sealed record DocumentTypeDto(Guid Id, string Name, string? Code,string? Description, bool Status);