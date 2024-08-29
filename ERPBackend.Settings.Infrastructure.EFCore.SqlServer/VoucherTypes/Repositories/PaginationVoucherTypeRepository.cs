namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.VoucherTypes.Repositories;

internal sealed class PaginationVoucherTypeRepository(SettingsApplicationDbContext dbContext)
    : IPaginationVoucherTypeRepository
{
    public async Task<PaginatedList<VoucherType>> HandleAsync(int pageIndex, int pageSize)
    {
        var voucherTypes = await dbContext.VoucherTypes
            .OrderBy(b => b.Id)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        var count = await dbContext.VoucherTypes.CountAsync();
        var totalPages = (int)Math.Ceiling(count / (double)pageSize);

        return new PaginatedList<VoucherType>(voucherTypes, pageIndex, totalPages);
    }
}