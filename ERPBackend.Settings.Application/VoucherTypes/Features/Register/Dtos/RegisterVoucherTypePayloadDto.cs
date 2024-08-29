namespace ERPBackend.Settings.Application.VoucherTypes.Features.Register.Dtos;

public sealed record RegisterVoucherTypePayloadDto(string Name, string? Code, string? Description);