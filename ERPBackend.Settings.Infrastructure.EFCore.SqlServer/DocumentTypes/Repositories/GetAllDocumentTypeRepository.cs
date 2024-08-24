namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.DocumentTypes.Repositories;

internal sealed class GetAllDocumentTypeRepository(SettingsApplicationDbContext dbContext)
    : IGetAllDocumentTypeRepository
{
    public async Task<IReadOnlyList<DocumentType>> HandleAsync() => await dbContext.DocumentTypes.ToListAsync();
}