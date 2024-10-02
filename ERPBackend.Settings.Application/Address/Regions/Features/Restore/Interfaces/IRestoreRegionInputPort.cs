namespace ERPBackend.Settings.Application.Address.Regions.Features.Restore.Interfaces;

public interface IRestoreRegionInputPort
{
    Task HandleAsync(Guid id);
}