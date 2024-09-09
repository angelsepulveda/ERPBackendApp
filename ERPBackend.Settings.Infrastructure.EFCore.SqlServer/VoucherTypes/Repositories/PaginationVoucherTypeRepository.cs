namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.VoucherTypes.Repositories;

internal sealed class PaginationVoucherTypeRepository(SettingsApplicationDbContext dbContext)
    : IPaginationVoucherTypeRepository
{
    public async Task<PaginatedList<VoucherType>> HandleAsync(int pageIndex, int pageSize, string? searchQuery)
    {
        var query = dbContext.VoucherTypes.AsQueryable();
        
        if (!string.IsNullOrEmpty(searchQuery))
        {
            query = query.Where(d => 
                d.Name.Contains(searchQuery) || 
                d.Description.Contains(searchQuery) ||
                d.Code.Contains(searchQuery)
            );
            pageIndex = 1;
        }
        
        var voucherTypes = await query
            .OrderBy(b => b.Id)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        var count = await dbContext.VoucherTypes.CountAsync();
        var totalPages = (int)Math.Ceiling(count / (double)pageSize);

        return new PaginatedList<VoucherType>(voucherTypes, pageIndex, totalPages);
    }
}