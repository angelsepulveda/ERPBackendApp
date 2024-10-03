namespace ERPBackend.Settings.Domain.Address.Municipalities.Interfaces.Repositories;

public interface IGetByIdMunicipalityRepository
{
    Task<Municipality?> HandleAsync(MunicipalityId id);
}