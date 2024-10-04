namespace ERPBackend.Settings.Infrastructure.Presenters.Address.Municipalities;

internal sealed class RegisterMunicipalityPresenter : IRegisterMunicipalityOutputPort
{
    public Guid MunicipalityId { get; private set; }
    public void Handle(Municipality municipality)
    {
        MunicipalityId = municipality.Id.Value;
    }
}