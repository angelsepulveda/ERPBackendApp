namespace ERPBackend.WareHouses.Application.Brands.Features.Pagination.Interfaces;

public interface IPaginationBrandOutputPort
{
    PaginationBrandResponseDto Response { get; }
    void Handle(PaginatedList<Brand> paginatedList);
}