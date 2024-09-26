namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Countries.Repositories;

internal sealed class PaginationCountryRepository(SettingsApplicationDbContext dbContext) : IPaginationCountryRepository
{
    public async Task<PaginatedList<Country>> HandleAsync(int pageIndex, int pageSize, string? searchQuery)
    {
        var query = dbContext.Countries.AsQueryable();

        if (!string.IsNullOrEmpty(searchQuery))
        {
            query = query.Where(d =>
                d.Name.Contains(searchQuery) ||
                d.Code.Contains(searchQuery)
            );
            pageIndex = 1;
        }

        var countries = await query
            .OrderBy(b => b.Id)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        var count = await dbContext.DocumentTypes.CountAsync();
        var totalPages = (int)Math.Ceiling(count / (double)pageSize);

        return new PaginatedList<Country>(countries, pageIndex, totalPages);
    }
}