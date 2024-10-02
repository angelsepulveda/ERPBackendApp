namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Regions.Repositories;

internal sealed class PaginationRegionRepository(SettingsApplicationDbContext dbContext) : IPaginationRegionRepository
{
    public async Task<PaginatedList<RegionWithRelation>> HandleAsync(int pageIndex, int pageSize, string? searchQuery)
    {
        var query = dbContext.Regions.Include(x => x.Country).AsQueryable();

        if (!string.IsNullOrEmpty(searchQuery))
        {
            query = query.Where(d =>
                d.Name.Contains(searchQuery) ||
                d.Code.Contains(searchQuery) ||
                d.Country.Name.Contains(searchQuery)
            );
            pageIndex = 1;
        }

        var regions = await query
            .OrderBy(b => b.Id)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .Select(c =>
                new RegionWithRelation(c.Id, c.Name, c.Code, c.Status, c.Country.Id,
                    c.Country.Name))
            .ToListAsync();

        var count = await dbContext.DocumentTypes.CountAsync();
        var totalPages = (int)Math.Ceiling(count / (double)pageSize);

        return new PaginatedList<RegionWithRelation>(regions, pageIndex, totalPages);
    }
}