namespace ERPBackend.Settings.Application.VoucherTypes.Features.Delete.Interfaces;

public interface IDeleteVoucherTypeInputPort
{
    Task HandleAsync(Guid id);
}