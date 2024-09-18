namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Categories.Repositories;

internal sealed class RegisterCategoryRepository(WareHousesApplicationDbContext dbContext) : IRegisterCategoryRepository
{
    public void Handle(Category category) => dbContext.Categories.Add(category);
}