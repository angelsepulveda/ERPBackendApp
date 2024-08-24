namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.DocumentTypes.Repositories;

internal sealed class GetDocumentTypeRepository(SettingsApplicationDbContext dbContext) : IGetDocumentTypeRepository
{
    public async Task<IReadOnlyList<DocumentType>> HandleAsync() =>
        await dbContext.DocumentTypes.Where(x => x.Status).ToListAsync();
}