namespace ERPBackend.Settings.Domain.Address.Municipalities.Interfaces.Repositories;

public interface IRegisterMunicipalityRepository
{
    void Handle(Municipality municipality);
}