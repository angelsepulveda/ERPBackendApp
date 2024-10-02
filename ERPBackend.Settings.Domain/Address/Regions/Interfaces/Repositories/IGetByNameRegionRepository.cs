namespace ERPBackend.Settings.Domain.Address.Regions.Interfaces.Repositories;

public interface IGetByNameRegionRepository
{
    Task<Region?> HandleAsync(string name);
}