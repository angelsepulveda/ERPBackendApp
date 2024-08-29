namespace ERPBackend.Settings.Application.VoucherTypes.Features.Register.Interfaces;

public interface IRegisterVoucherTypeInputPort 
{
    Task HandleAsync(RegisterVoucherTypePayloadDto payload);
}