namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Brands.Repositories;

internal sealed class GetBrandRepository(WareHousesApplicationDbContext dbContext) : IGetBrandRepository
{
    public async Task<IReadOnlyList<Brand>> HandleAsync() =>
        await dbContext.Brands.Where(x => x.Status == true).ToListAsync();
}