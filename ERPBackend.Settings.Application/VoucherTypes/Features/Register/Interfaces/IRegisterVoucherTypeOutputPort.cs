namespace ERPBackend.Settings.Application.VoucherTypes.Features.Register.Interfaces;

public interface IRegisterVoucherTypeOutputPort
{
    Guid VoucherTypeId { get; }
    void Handle(VoucherType voucherType);
}