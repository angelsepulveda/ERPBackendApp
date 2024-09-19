namespace ERPBackend.WareHouses.Application.Brands.Features.Update.Dtos;

public sealed record UpdateBrandPayloadDto(Guid Id, string Name, string? Description);