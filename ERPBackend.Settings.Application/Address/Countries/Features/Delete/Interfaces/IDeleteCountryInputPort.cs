namespace ERPBackend.Settings.Application.Address.Countries.Features.Delete.Interfaces;

public interface IDeleteCountryInputPort
{
    Task HandleAsync(Guid id);
}