namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Categories.Repositories;

internal sealed class GetCategoryRepository(WareHousesApplicationDbContext dbContext) : IGetCategoryRepository
{
    public async Task<IReadOnlyList<Category>> HandleAsync() =>
        await dbContext.Categories.Where(x => x.Status == true).ToListAsync();
}