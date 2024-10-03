namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Regions.Configurations;

public class RegionConfiguration : IEntityTypeConfiguration<Region>
{
    public void Configure(EntityTypeBuilder<Region> builder)
    {
        builder.ToTable("Region");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnType("char(36)").HasConversion(x => x.Value, x => new RegionId(x));
        builder.Property(x => x.CountryId).HasColumnType("char(36)").HasConversion(x => x.Value, x => new CountryId(x));
        builder.Property(x => x.Name).HasColumnType("varchar(150)").HasMaxLength(150).IsRequired();
        builder.Property(x => x.Code).HasColumnType("varchar(10)").HasMaxLength(10);
        builder.Property(x => x.Status).IsRequired();
        builder.Property(x => x.CreatedBy).HasColumnType("varchar(255)").HasMaxLength(255);
        builder.Property(x => x.UpdatedBy).HasColumnType("varchar(255)").HasMaxLength(255);

        //relaciones
        builder.HasOne(u => u.Country).WithOne().HasForeignKey<Region>("CountryId").OnDelete(DeleteBehavior.Restrict);
    }
}