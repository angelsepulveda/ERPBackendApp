namespace ERPBackend.Settings.Infrastructure.Presenters.VoucherTypes;

internal sealed class UpdateVoucherTypePresenter : IUpdateVoucherTypeOutputPort
{
    public UpdateVoucherTypeResponseDto Response { get; private set; }
    public void Handle(VoucherType voucherType)
    {
        Response = new UpdateVoucherTypeResponseDto(Id: voucherType.Id.Value, Name: voucherType.Name,
            Code: voucherType.Code, Description: voucherType.Description);
    }
}