namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.DocumentTypes.Repositories;

internal sealed class RegisterDocumentTypeRepository(SettingsApplicationDbContext dbContext)
    : IRegisterDocumentTypeRepository
{
    public void Handle(DocumentType documentType) => dbContext.DocumentTypes.Add(documentType);
}