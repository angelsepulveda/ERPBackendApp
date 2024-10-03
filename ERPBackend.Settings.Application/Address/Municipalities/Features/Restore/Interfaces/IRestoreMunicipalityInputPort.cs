namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Restore.Interfaces;

public interface IRestoreMunicipalityInputPort
{
    Task HandleAsync(Guid id);
}