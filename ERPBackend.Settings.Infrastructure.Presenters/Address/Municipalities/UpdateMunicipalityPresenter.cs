namespace ERPBackend.Settings.Infrastructure.Presenters.Address.Municipalities;

internal sealed class UpdateMunicipalityPresenter : IUpdateMunicipalityOutputPort
{
    public UpdateMunicipalityResponseDto Response { get; private set; }

    public void Handle(Municipality municipality)
    {
        Response = new UpdateMunicipalityResponseDto(municipality.Id.Value, municipality.Name,
            municipality.Country.Id.Value, municipality.Region.Id.Value, municipality.Code);
    }
}