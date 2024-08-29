namespace ERPBackend.Settings.Application.VoucherTypes.Features.Update.Interfaces;

public interface IUpdateVoucherTypeOutputPort
{
    UpdateVoucherTypeResponseDto Response { get; }
    void Handle(VoucherType voucherType);
}