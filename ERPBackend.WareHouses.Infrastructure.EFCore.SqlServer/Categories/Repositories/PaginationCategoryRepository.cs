namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Categories.Repositories;

internal sealed class PaginationCategoryRepository(WareHousesApplicationDbContext dbContext) : IPaginationCategoryRepository
{
    public async Task<PaginatedList<Category>> HandleAsync(int pageIndex, int pageSize, string? searchQuery)
    {
        var query = dbContext.Categories.AsQueryable();
        
        if (!string.IsNullOrEmpty(searchQuery))
        {
            query = query.Where(d => 
                d.Name.Contains(searchQuery) || 
                d.Description.Contains(searchQuery)
            );
            pageIndex = 1;
        }
        
        var categories = await query
            .OrderBy(b => b.Id)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        var count = await dbContext.Categories.CountAsync();
        var totalPages = (int)Math.Ceiling(count / (double)pageSize);

        return new PaginatedList<Category>(categories, pageIndex, totalPages);
    }
}