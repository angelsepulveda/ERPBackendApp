namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Municipalities.Configurations;

public class MunicipalityConfiguration : IEntityTypeConfiguration<Municipality>
{
    public void Configure(EntityTypeBuilder<Municipality> builder)
    {
        builder.ToTable("Municipality");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnType("char(36)").HasConversion(x => x.Value, x => new MunicipalityId(x));
        builder.Property(x => x.CountryId).HasColumnType("char(36)").HasConversion(x => x.Value, x => new CountryId(x));
        builder.Property(x => x.RegionId).HasColumnType("char(36)").HasConversion(x => x.Value, x => new RegionId(x));
        builder.Property(x => x.Name).HasColumnType("varchar(150)").HasMaxLength(150).IsRequired();
        builder.Property(x => x.Code).HasColumnType("varchar(10)").HasMaxLength(10);
        builder.Property(x => x.Status).IsRequired();
        builder.Property(x => x.CreatedBy).HasColumnType("varchar(255)").HasMaxLength(255);
        builder.Property(x => x.UpdatedBy).HasColumnType("varchar(255)").HasMaxLength(255);

        //relaciones
        builder.HasOne(u => u.Country).WithOne().HasForeignKey<Municipality>("CountryId")
            .OnDelete(DeleteBehavior.Restrict);
        ;
        builder.HasOne(u => u.Region).WithOne().HasForeignKey<Municipality>("RegionId")
            .OnDelete(DeleteBehavior.Restrict);
        ;
    }
}