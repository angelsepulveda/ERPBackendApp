namespace ERPBackend.Settings.Application.Address.Regions.Features.Delete.Interfaces;

public interface IDeleteRegionInputPort
{
    Task HandleAsync(Guid id);
}