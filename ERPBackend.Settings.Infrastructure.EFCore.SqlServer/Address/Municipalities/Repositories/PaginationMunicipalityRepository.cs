namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Municipalities.Repositories;

internal sealed class PaginationMunicipalityRepository(SettingsApplicationDbContext dbContext)
    : IPaginationMunicipalityRepository
{
    public async Task<PaginatedList<MunicipalityWithRelations>> HandleAsync(int pageIndex, int pageSize,
        string? searchQuery)
    {
        var query = dbContext.Municipalities.Include(x => x.Region).Include(x => x.Country).AsQueryable();

        if (!string.IsNullOrEmpty(searchQuery))
        {
            query = query.Where(d =>
                d.Name.Contains(searchQuery) ||
                d.Code.Contains(searchQuery) ||
                d.Country.Name.Contains(searchQuery) ||
                d.Region.Name.Contains(searchQuery)
            );
            pageIndex = 1;
        }

        var municipalities = await query
            .OrderBy(b => b.Id)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .Select(c =>
                new MunicipalityWithRelations(c.Id, c.Name, c.Code, c.Status, c.Country.Id,
                    c.Country.Name, c.RegionId, c.Region.Name))
            .ToListAsync();

        var count = await dbContext.DocumentTypes.CountAsync();
        var totalPages = (int)Math.Ceiling(count / (double)pageSize);

        return new PaginatedList<MunicipalityWithRelations>(municipalities, pageIndex, totalPages);
    }
}