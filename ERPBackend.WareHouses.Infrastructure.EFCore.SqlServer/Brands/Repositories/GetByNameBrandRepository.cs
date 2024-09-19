namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Brands.Repositories;

internal sealed class GetByNameBrandRepository(WareHousesApplicationDbContext dbContext) : IGetByNameBrandRepository
{
    public async Task<Brand?> HandleAsync(string name) =>
        await dbContext.Brands.Where(x => x.Name == name).FirstOrDefaultAsync();
}