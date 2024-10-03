namespace ERPBackend.Settings.Domain.Address.Municipalities.Interfaces.Repositories;

public interface IPaginationMunicipalityRepository
{
    Task<PaginatedList<MunicipalityWithRelations>> HandleAsync(int pageIndex, int pageSize, string? searchQuery);
}