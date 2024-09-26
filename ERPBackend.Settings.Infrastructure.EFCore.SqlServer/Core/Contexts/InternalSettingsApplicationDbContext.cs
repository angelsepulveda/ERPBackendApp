namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Core.Contexts;

internal class InternalSettingsApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost;Database=ERP_DEV2;Integrated Security=True;TrustServerCertificate=True");
        base.OnConfiguring(optionsBuilder);
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        
        base.OnModelCreating(modelBuilder);
    }
    
    public DbSet<DocumentType> DocumentTypes { get; set; }
    public DbSet<VoucherType> VoucherTypes { get; set; }
    public DbSet<Country> Countries { get; set; }
}