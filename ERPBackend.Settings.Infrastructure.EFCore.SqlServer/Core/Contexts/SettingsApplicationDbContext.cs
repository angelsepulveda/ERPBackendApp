namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Core.Contexts;

public class SettingsApplicationDbContext : DbContext, IUnitOfWork
{
    public SettingsApplicationDbContext(DbContextOptions<SettingsApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DocumentTypeConfiguration).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }

    public DbSet<DocumentType> DocumentTypes { get; set; }
    public DbSet<VoucherType> VoucherTypes { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Municipality> Municipalities { get; set; }
}