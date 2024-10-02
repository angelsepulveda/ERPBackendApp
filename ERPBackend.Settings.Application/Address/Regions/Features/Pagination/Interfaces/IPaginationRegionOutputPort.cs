namespace ERPBackend.Settings.Application.Address.Regions.Features.Pagination.Interfaces;

public interface IPaginationRegionOutputPort
{
    PaginationRegionResponseDto Response { get; }
    void Handle(PaginatedList<RegionWithRelation> paginatedList);
}