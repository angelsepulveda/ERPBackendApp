namespace ERPBackend.Settings.Domain.Address.Countries.Interfaces.Repositories;

public interface IPaginationCountryRepository
{
    Task<PaginatedList<Country>> HandleAsync(int pageIndex, int pageSize, string? searchQuery);
}