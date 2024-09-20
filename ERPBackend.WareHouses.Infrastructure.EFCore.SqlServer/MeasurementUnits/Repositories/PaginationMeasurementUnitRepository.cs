namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.MeasurementUnits.Repositories;

internal sealed class PaginationMeasurementUnitRepository(WareHousesApplicationDbContext dbContext) : IPaginationMeasurementUnitRepository
{
    public async Task<PaginatedList<MeasurementUnit>> HandleAsync(int pageIndex, int pageSize, string? searchQuery)
    {
        var query = dbContext.MeasurementUnits.AsQueryable();
        
        if (!string.IsNullOrEmpty(searchQuery))
        {
            query = query.Where(d => 
                d.Name.Contains(searchQuery) || 
                d.Prefix.Contains(searchQuery) ||
                d.Description.Contains(searchQuery)
            );
            pageIndex = 1;
        }
        
        var measurementUnits = await query
            .OrderBy(b => b.Id)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        var count = await dbContext.MeasurementUnits.CountAsync();
        var totalPages = (int)Math.Ceiling(count / (double)pageSize);

        return new PaginatedList<MeasurementUnit>(measurementUnits, pageIndex, totalPages);
    }
}