namespace ERPBackend.Settings.Application.Address.Countries.Features.Update.Interfaces;

public interface IUpdateCountryOutputPort
{
    UpdateCountryResponseDto Response { get; }
    void Handle(Country country);
}