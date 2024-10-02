namespace ERPBackend.Settings.Domain.Address.Regions.Interfaces.Services;

public interface IExistByCodeRegionValidationService
{
    Task HandleAsync(Region region);
}