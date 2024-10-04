namespace ERPBackend.Settings.Infrastructure.Presenters.Address.Municipalities;

internal sealed class PaginationMunicipalityPresenter : IPaginationMunicipalityOutputPort
{
    public PaginationMunicipalityResponseDto Response { get; private set; }

    public void Handle(PaginatedList<MunicipalityWithRelations> paginatedList)
    {
        var dtos = paginatedList.Items
            .Select(x => new PaginationMunicipalityDto(x.Id.Value, x.Name, x.Code, x.Status, x.CountryId.Value,
                x.Country, x.RegionId.Value, x.Region)).ToList();

        Response = new PaginationMunicipalityResponseDto(Data: dtos,
            PageIndex: paginatedList.PageIndex, TotalPages: paginatedList.TotalPages,
            HasPreviousPage: paginatedList.HasPreviousPage, HasNextPage: paginatedList.HasNextPage);
    }
}