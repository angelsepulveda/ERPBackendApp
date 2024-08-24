namespace ERPBackend.Settings.Application.DocumentTypes.Features.Register.UseCases;

internal sealed class RegisterDocumentTypeInteractor(
    IRegisterDocumentTypeRepository repository,
    IUnitOfWork unitOfWork,
    IRegisterDocumentTypeOutputPort presenter)
    : IRegisterDocumentTypeInputPort
{
    public async Task HandleAsync(RegisterDocumentTypePayloadDto payload)
    {
        var documentType = DocumentType.Create(payload.Name, payload.Code, payload.Description);

        repository.Handle(documentType);

       var result = await unitOfWork.SaveChangesAsync();

        await presenter.HandleAsync(documentType);
    }
}