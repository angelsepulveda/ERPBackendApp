namespace ERPBackend.Settings.Domain.Address.Municipalities.Interfaces.Repositories;

public interface IGetByNameMunicipalityRepository
{
    Task<Municipality?> HandleAsync(string name);
}