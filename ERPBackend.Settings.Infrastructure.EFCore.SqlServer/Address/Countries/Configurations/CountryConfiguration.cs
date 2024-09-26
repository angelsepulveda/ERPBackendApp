namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Countries.Configurations;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.ToTable("Country");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnType("char(36)").HasConversion(x => x.Value, x => new CountryId(x));
        builder.Property(x => x.Name).HasColumnType("varchar(150)").HasMaxLength(150).IsRequired();
        builder.Property(x => x.Code).HasColumnType("varchar(10)").HasMaxLength(10);
        builder.Property(x => x.Status).IsRequired();
        builder.Property(x => x.CreatedBy).HasColumnType("varchar(255)").HasMaxLength(255);
        builder.Property(x => x.UpdatedBy).HasColumnType("varchar(255)").HasMaxLength(255);
    }
}