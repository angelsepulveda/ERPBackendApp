namespace ERPBackend.Settings.Application.Address.Countries.Features.Pagination.Interfaces;

public interface IPaginationCountryOutputPort
{
    PaginationCountryResponseDto Response { get; }
    void Handle(PaginatedList<Country> paginatedList);
}