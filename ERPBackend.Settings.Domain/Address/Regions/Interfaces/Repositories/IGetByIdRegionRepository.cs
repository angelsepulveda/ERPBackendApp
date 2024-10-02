namespace ERPBackend.Settings.Domain.Address.Regions.Interfaces.Repositories;

public interface IGetByIdRegionRepository
{
    Task<Region?> HandleAsync(RegionId id);
}