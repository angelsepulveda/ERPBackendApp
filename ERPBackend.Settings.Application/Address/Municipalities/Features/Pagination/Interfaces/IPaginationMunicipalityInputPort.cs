namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Pagination.Interfaces;

public interface IPaginationMunicipalityInputPort
{
    Task HandleAsync(PaginationMunicipalityPayloadDto payload);
}