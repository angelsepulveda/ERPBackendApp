namespace ERPBackend.WareHouses.Application.Brands.Features.Pagination.Dtos;

public sealed record BrandDto(Guid Id, string Name, string? Description, bool Status);