namespace ERPBackend.Settings.Application.Address.Countries.Features.Restore.Interfaces;

public interface IRestoreCountryInputPort
{
    Task HandleAsync(Guid id);
}