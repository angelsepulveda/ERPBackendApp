namespace ERPBackend.Settings.Application.DocumentTypes.Features.Update.Dtos;

public sealed record UpdateDocumentTypePayloadDto(Guid Id, string Name, string? Code, string? Description);
