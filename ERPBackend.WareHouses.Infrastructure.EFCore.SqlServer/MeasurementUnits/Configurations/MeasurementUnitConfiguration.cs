namespace ERPBackend.WareHouses.Infrastructure.EFCore.SqlServer.MeasurementUnits.Configurations;

public class MeasurementUnitConfiguration : IEntityTypeConfiguration<MeasurementUnit>
{
    public void Configure(EntityTypeBuilder<MeasurementUnit> builder)
    {
        builder.ToTable("MeasureUnit");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnType("char(36)").HasConversion(x => x.Value, x => new MeasurementUnitId(x));
        builder.Property(x => x.Prefix).HasColumnType("varchar(6)").HasMaxLength(6);
        builder.Property(x => x.Name).HasColumnType("varchar(50)").HasMaxLength(50).IsRequired();
        builder.Property(x => x.Description).HasColumnType("varchar(255)").HasMaxLength(255);
        builder.Property(x => x.Status).IsRequired();
        builder.Property(x => x.CreatedBy).HasColumnType("varchar(255)").HasMaxLength(255);
        builder.Property(x => x.UpdatedBy).HasColumnType("varchar(255)").HasMaxLength(255);
    }
}