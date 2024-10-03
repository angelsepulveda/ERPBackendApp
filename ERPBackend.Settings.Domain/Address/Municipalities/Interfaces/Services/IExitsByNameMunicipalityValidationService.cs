namespace ERPBackend.Settings.Domain.Address.Municipalities.Interfaces.Services;

public interface IExitsByNameMunicipalityValidationService
{
    Task HandleAsync(Municipality municipality);
}