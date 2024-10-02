namespace ERPBackend.Settings.Domain.Address.Regions.Interfaces.Repositories;

public interface IGetByCodeRegionRepository
{
    Task<Region?> HandleAsync(string code);
}