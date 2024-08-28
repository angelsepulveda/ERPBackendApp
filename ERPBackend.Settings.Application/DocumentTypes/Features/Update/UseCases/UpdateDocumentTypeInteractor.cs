namespace ERPBackend.Settings.Application.DocumentTypes.Features.Update.UseCases;

internal sealed class UpdateDocumentTypeInteractor(
    IUpdateDocumentTypeRepository updateRepository,
    IUnitOfWork unitOfWork,
    IGetByIdDocumentTypeRepository getByIdRepository,
    IUpdateDocumentTypeOutputPort presenter,
    IModelValidatorHub<UpdateDocumentTypePayloadDto> updateDocumentTypeValidator) : IUpdateDocumentTypeInputPort
{
    public async Task HandleAsync(UpdateDocumentTypePayloadDto payload)
    {
        if (!await updateDocumentTypeValidator.Validate(payload))
            throw new ValidationException(updateDocumentTypeValidator.Errors);
        
        var documentType = await getByIdRepository.HandleAsync(new DocumentTypeId(payload.Id));

        if (documentType is null) throw new DocumentTypeNotFoundException();
        
        documentType.Update(payload.Name, payload.Code, payload.Description);
        
        updateRepository.Handle(documentType);

        await unitOfWork.SaveChangesAsync();

        presenter.Handle(documentType);
    }
}