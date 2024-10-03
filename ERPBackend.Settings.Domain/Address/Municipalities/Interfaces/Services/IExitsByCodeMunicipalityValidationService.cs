namespace ERPBackend.Settings.Domain.Address.Municipalities.Interfaces.Services;

public interface IExitsByCodeMunicipalityValidationService
{
    Task HandleAsync(Municipality municipality);
}