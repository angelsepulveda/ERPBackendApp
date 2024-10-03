namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Register.Interfaces;

public interface IRegisterMunicipalityOutputPort
{
    Guid MunicipalityId { get; }
    void Handle(Municipality municipality);
}