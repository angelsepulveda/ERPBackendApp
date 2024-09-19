namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Brands.Repositories;

internal sealed class PaginationBrandRepository(WareHousesApplicationDbContext dbContext) : IPaginationBrandRepository
{
    public async Task<PaginatedList<Brand>> HandleAsync(int pageIndex, int pageSize, string? searchQuery)
    {
        var query = dbContext.Brands.AsQueryable();

        if (!string.IsNullOrEmpty(searchQuery))
        {
            query = query.Where(d =>
                d.Name.Contains(searchQuery) ||
                d.Description.Contains(searchQuery)
            );
            pageIndex = 1;
        }

        var brands = await query
            .OrderBy(b => b.Id)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        var count = await dbContext.Categories.CountAsync();
        var totalPages = (int)Math.Ceiling(count / (double)pageSize);

        return new PaginatedList<Brand>(brands, pageIndex, totalPages);
    }
}