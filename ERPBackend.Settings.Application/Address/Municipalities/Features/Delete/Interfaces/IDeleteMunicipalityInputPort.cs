namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Delete.Interfaces;

public interface IDeleteMunicipalityInputPort
{
    Task HandleAsync(Guid id);
}