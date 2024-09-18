namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Categories.Repositories;

internal sealed class GetByIdCategoryRepository(WareHousesApplicationDbContext dbContext) : IGetByIdCategoryRepository
{
    public async Task<Category?> HandleAsync(CategoryId id) =>
        await dbContext.Categories.Where(x => x.Id == id).FirstOrDefaultAsync();
}