namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.DocumentTypes.Repositories;

internal sealed class GetByIdDocumentTypeRepository(SettingsApplicationDbContext dbContext)
    : IGetByIdDocumentTypeRepository
{
    public async Task<DocumentType?> HandleAsync(DocumentTypeId id) =>
        await dbContext.DocumentTypes.Where(x => x.Id == id).FirstOrDefaultAsync();
}