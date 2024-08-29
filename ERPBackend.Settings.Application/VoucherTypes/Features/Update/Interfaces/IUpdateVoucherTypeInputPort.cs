namespace ERPBackend.Settings.Application.VoucherTypes.Features.Update.Interfaces;

public interface IUpdateVoucherTypeInputPort
{
    Task HandleAsync(UpdateVoucherTypePayloadDto payload);
}