namespace ERPBackend.Settings.Domain.Address.Regions.Interfaces.Repositories;

public interface IGetRegionRepository
{
    Task<IReadOnlyList<Region>> HandleAsync();
}