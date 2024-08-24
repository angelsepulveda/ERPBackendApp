namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.DocumentTypes.Configurations;

public class DocumentTypeConfiguration : IEntityTypeConfiguration<DocumentType>
{
    public void Configure(EntityTypeBuilder<DocumentType> builder)
    {
        builder.ToTable("DocumentType");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnType("char(36)").HasConversion(x => x.Value, x => new DocumentTypeId(x));
        builder.Property(x => x.Name).HasColumnType("varchar(20)").HasMaxLength(20).IsRequired();
        builder.Property(x => x.Code).HasColumnType("varchar(10)").HasMaxLength(10);
        builder.Property(x => x.Description).HasColumnType("varchar(255)").HasMaxLength(255);
        builder.Property(x => x.Status).IsRequired();
        builder.Property(x => x.CreatedBy).HasColumnType("varchar(255)").HasMaxLength(255);
        builder.Property(x => x.UpdatedBy).HasColumnType("varchar(255)").HasMaxLength(255);
    }
}