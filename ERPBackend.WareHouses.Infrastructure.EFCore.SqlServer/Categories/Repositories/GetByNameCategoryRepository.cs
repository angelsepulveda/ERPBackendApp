namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Categories.Repositories;

internal sealed class GetByNameCategoryRepository(WareHousesApplicationDbContext dbContext)
    : IGetByNameCategoryRepository
{
    public async Task<Category?> HandleAsync(string name) =>
        await dbContext.Categories.Where(x => x.Name == name).FirstOrDefaultAsync();
}