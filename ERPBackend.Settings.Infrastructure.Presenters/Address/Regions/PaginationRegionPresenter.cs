namespace ERPBackend.Settings.Infrastructure.Presenters.Address.Regions;

internal sealed class PaginationRegionPresenter : IPaginationRegionOutputPort
{
    public PaginationRegionResponseDto Response { get; private set; }

    public void Handle(PaginatedList<RegionWithRelation> paginatedList)
    {
        var dtos = paginatedList.Items
            .Select(x => new PaginationRegionDto(Id: x.Id.Value, Name: x.Name, Code: x.Code,
                Status: x.Status, x.CountryId.Value, x.Country)).ToList();

        Response = new PaginationRegionResponseDto(Data: dtos,
            PageIndex: paginatedList.PageIndex, TotalPages: paginatedList.TotalPages,
            HasPreviousPage: paginatedList.HasPreviousPage, HasNextPage: paginatedList.HasNextPage);
    }
}
