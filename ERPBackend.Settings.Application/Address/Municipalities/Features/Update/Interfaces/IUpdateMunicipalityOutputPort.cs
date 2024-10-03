namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Update.Interfaces;

public interface IUpdateMunicipalityOutputPort
{
    UpdateMunicipalityResponseDto Response { get; }
    void Handle(Municipality municipality);
}