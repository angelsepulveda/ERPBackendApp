namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Brands.Repositories;

internal sealed class UpdateBrandRepository(WareHousesApplicationDbContext dbContext) : IUpdateBrandRepository
{
    public void Handle(Brand brand) => dbContext.Brands.Update(brand);
}