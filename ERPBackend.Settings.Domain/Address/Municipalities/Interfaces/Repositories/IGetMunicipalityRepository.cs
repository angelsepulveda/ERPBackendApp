namespace ERPBackend.Settings.Domain.Address.Municipalities.Interfaces.Repositories;

public interface IGetMunicipalityRepository
{
    Task<IReadOnlyList<Municipality>> HandleAsync();
}