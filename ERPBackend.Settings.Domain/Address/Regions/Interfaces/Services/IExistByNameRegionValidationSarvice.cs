namespace ERPBackend.Settings.Domain.Address.Regions.Interfaces.Services;

public interface IExistByNameRegionValidationSarvice
{
    Task HandleAsync(Region region);
}