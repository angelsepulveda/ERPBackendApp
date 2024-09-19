namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Brands.Repositories;

internal sealed class GetByIdBrandRepository(WareHousesApplicationDbContext dbContext) : IGetByIdBrandRepository
{
    public async Task<Brand?> HandleAsync(BrandId id) =>
        await dbContext.Brands.Where(x => x.Id == id).FirstOrDefaultAsync();
}