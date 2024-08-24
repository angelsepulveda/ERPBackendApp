namespace ERPBackend.Settings.Application.DocumentTypes.Features.Restore.UseCases;

internal sealed class RestoreDocumentTypeInteractor(
    IUpdateDocumentTypeRepository updateRepository,
    IGetByIdDocumentTypeRepository getByIdRepository,
    IUnitOfWork unitOfWork) : IRestoreDocumentTypeInputPort
{
    public async Task HandleAsync(Guid id)
    {
        var documentType = await getByIdRepository.HandleAsync(new DocumentTypeId(id));

        if (documentType is null) throw new DocumentTypeNotFoundException();

        documentType.Restore();

        updateRepository.Handle(documentType);

        await unitOfWork.SaveChangesAsync();
    }
}