namespace ERPBackend.Settings.Infrastructure.Presenters.Address.Countries;

internal sealed class PaginationCountryPresenter : IPaginationCountryOutputPort
{
    public PaginationCountryResponseDto Response { get; private set; }

    public void Handle(PaginatedList<Country> paginatedList)
    {
        var dtos = paginatedList.Items
            .Select(x => new CountryDto(Id: x.Id.Value, Name: x.Name, Code: x.Code,
                Status: x.Status)).ToList();

        Response = new PaginationCountryResponseDto(Data: dtos,
            PageIndex: paginatedList.PageIndex, TotalPages: paginatedList.TotalPages,
            HasPreviousPage: paginatedList.HasPreviousPage, HasNextPage: paginatedList.HasNextPage);
    }
}