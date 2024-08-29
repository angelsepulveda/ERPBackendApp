namespace ERPBackend.Settings.Infrastructure.Presenters.VoucherTypes;

internal sealed class RegisterVoucherTypePresenter : IRegisterVoucherTypeOutputPort
{
    public Guid VoucherTypeId { get; private set; }

    public void Handle(VoucherType voucherType)
    {
        VoucherTypeId = voucherType.Id.Value;
    }
}