namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Brands.Repositories;

internal sealed class RegisterBrandRepository(WareHousesApplicationDbContext dbContext) : IRegisterBrandRepository
{
    public void Handle(Brand brand) => dbContext.Brands.Add(brand);
}