namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Categories.Repositories;

internal sealed class UpdateCategoryRepository(WareHousesApplicationDbContext dbContext) : IUpdateCategoryRepository
{
    public void Handle(Category category) => dbContext.Categories.Update(category);
}