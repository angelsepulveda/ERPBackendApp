namespace ERPBackend.WareHouses.Application.Categories.Features.Pagination.Dtos;

public sealed record CategoryDto(Guid Id, string Name, string? Description, bool Status);