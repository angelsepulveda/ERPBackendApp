namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.DocumentTypes.Repositories;

internal sealed class UpdateDocumentTypeRepository(SettingsApplicationDbContext dbContext)
    : IUpdateDocumentTypeRepository
{
    public void Handle(DocumentType documentType) => dbContext.DocumentTypes.Update(documentType);
}