namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.Brands.Configurations;

public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.ToTable("Brand");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnType("char(36)").HasConversion(x => x.Value, x => new BrandId(x));
        builder.Property(x => x.Name).HasColumnType("varchar(50)").HasMaxLength(50).IsRequired();
        builder.Property(x => x.Description).HasColumnType("varchar(255)").HasMaxLength(255);
        builder.Property(x => x.Status).IsRequired();
        builder.Property(x => x.CreatedBy).HasColumnType("varchar(255)").HasMaxLength(255);
        builder.Property(x => x.UpdatedBy).HasColumnType("varchar(255)").HasMaxLength(255);
    }
}