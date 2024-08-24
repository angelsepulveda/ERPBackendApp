namespace ERPBackend.Settings.Application.DocumentTypes.Features.Delete.UseCases;

internal sealed class DeleteDocumentTypeInteractor(
    IUpdateDocumentTypeRepository updateRepository,
    IGetByIdDocumentTypeRepository getByIdRwepository,
    IUnitOfWork unitOfWork)
    : IDeleteDocumentTypeInputPort
{
    public async Task HandleAsync(Guid id)
    {
        var documentType = await getByIdRwepository.HandleAsync(new DocumentTypeId(id));

        if (documentType is null) throw new DocumentTypeNotFoundException();
        
        documentType.Delete();
        
        updateRepository.Handle(documentType);
        
        await unitOfWork.SaveChangesAsync();

    }
}