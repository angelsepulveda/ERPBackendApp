namespace ERPBackend.Settings.Domain.Address.Municipalities.Interfaces.Repositories;

public interface IUpdateMunicipalityRepository
{
    void Handle(Municipality municipality);
}