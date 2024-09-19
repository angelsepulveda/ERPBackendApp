namespace ERPBackend.WareHouses.Infrastructure.Presenters.Brands;

internal sealed class PaginationBrandPresenter : IPaginationBrandOutputPort
{
    public PaginationBrandResponseDto Response { get; private set;  }
    public void Handle(PaginatedList<Brand> paginatedList)
    {
        var dtos = paginatedList.Items
            .Select(x => new BrandDto(Id: x.Id.Value, Name: x.Name, Description: x.Description,
                Status: x.Status)).ToList();

        Response  = new PaginationBrandResponseDto(Data: dtos,
            PageIndex: paginatedList.PageIndex, TotalPages: paginatedList.TotalPages,
            HasPreviousPage: paginatedList.HasPreviousPage, HasNextPage: paginatedList.HasNextPage);
    }
}