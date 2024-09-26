namespace ERPBackend.Settings.Application.Address.Countries.Features.Pagination.UseCases;

internal sealed class PaginationCountryInteractor(
    IPaginationCountryRepository repository,
    IPaginationCountryOutputPort outputPort) : IPaginationCountryInputPort
{
    public async Task HandleAsync(PaginationCountryPaylaodDto paylaodDto)
    {
        var paginatedCountries =
            await repository.HandleAsync(paylaodDto.PageIndex, paylaodDto.PageSize, paylaodDto.Search);

        outputPort.Handle(paginatedCountries);
    }
}