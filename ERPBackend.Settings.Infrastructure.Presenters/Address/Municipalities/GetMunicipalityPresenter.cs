namespace ERPBackend.Settings.Infrastructure.Presenters.Address.Municipalities;

internal sealed class GetMunicipalityPresenter : IGetMunicipalityOutputPort
{
    public IReadOnlyList<GetMunicipalityResponseDto> Response { get; private set; }

    public void Handle(IReadOnlyList<Municipality> municipalities)
    {
        Response = municipalities.Select(x =>
                new GetMunicipalityResponseDto(x.Id.Value, x.Name, x.Region.Id.Value, x.Country.Id.Value)).ToList()
            .AsReadOnly();
    }
}