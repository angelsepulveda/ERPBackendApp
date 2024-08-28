namespace ERPBackend.Settings.Application.DocumentTypes.Features.Update.Dtos;

public sealed record UpdateDocumentTypeResponseDto(Guid Id, string Name, string? Code, string? Description);