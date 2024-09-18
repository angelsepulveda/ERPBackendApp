namespace ERPBackend.WareHouses.Application.Categories.Features.Update.Dtos;

public sealed record UpdateCategoryPayloadDto(Guid Id, string Name, string? Description);