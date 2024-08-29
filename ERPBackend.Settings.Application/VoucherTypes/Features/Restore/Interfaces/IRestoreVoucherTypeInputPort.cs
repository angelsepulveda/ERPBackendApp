namespace ERPBackend.Settings.Application.VoucherTypes.Features.Restore.Interfaces;

public interface IRestoreVoucherTypeInputPort
{
    Task HandleAsync(Guid id);
}