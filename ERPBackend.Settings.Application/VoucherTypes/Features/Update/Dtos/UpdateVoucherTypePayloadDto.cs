namespace ERPBackend.Settings.Application.VoucherTypes.Features.Update.Dtos;

public sealed record UpdateVoucherTypePayloadDto(Guid Id, string Name, string? Code, string? Description);