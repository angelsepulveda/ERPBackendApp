namespace ERPBackend.Settings.Domain.Address.Municipalities.Interfaces.Repositories;

public interface IGetByCodeMunicipalityRepository
{
    Task<Municipality?> HandleAsync(string code);
}