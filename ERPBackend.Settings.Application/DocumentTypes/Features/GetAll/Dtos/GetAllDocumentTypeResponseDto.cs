namespace ERPBackend.Settings.Application.DocumentTypes.Features.GetAll.Dtos;

public record GetAllDocumentTypeResponseDto(Guid Ied, string Name, string? Code, string? Description, bool Status);