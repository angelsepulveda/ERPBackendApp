namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Core.Contexts;

internal class WareHousesApplicationDbContext: DbContext, IWareHouseUnitOfWork
{
    public WareHousesApplicationDbContext(DbContextOptions<WareHousesApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfiguration).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<MeasurementUnit> MeasurementUnits { get; set; }
}