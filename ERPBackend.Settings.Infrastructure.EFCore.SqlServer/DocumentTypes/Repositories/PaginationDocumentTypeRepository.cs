namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.DocumentTypes.Repositories;

internal sealed class PaginationDocumentTypeRepository(SettingsApplicationDbContext dbContext)
    : IPaginationDocumentTypeRepository
{
    public async Task<PaginatedList<DocumentType>> HandleAsync(int pageIndex, int pageSize, string? searchQuery)
    {
        var query = dbContext.DocumentTypes.AsQueryable();
        
        if (!string.IsNullOrEmpty(searchQuery))
        {
            query = query.Where(d => 
                d.Name.Contains(searchQuery) || 
                d.Description.Contains(searchQuery) ||
                d.Code.Contains(searchQuery)
            );
            pageIndex = 1;
        }
        
        var documentTypes = await query
            .OrderBy(b => b.Id)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        var count = await dbContext.DocumentTypes.CountAsync();
        var totalPages = (int)Math.Ceiling(count / (double)pageSize);

        return new PaginatedList<DocumentType>(documentTypes, pageIndex, totalPages);
    }
}