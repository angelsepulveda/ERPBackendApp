namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Pagination.UseCases;

internal sealed class PaginationMunicipalityInteractor(
    IPaginationMunicipalityRepository repository,
    IPaginationMunicipalityOutputPort outputPort) : IPaginationMunicipalityInputPort
{
    public async Task HandleAsync(PaginationMunicipalityPayloadDto payload)
    {
        var paginatedMunicipalities =
            await repository.HandleAsync(payload.PageIndex, payload.PageSize, payload.Search);

        outputPort.Handle(paginatedMunicipalities);
    }
}