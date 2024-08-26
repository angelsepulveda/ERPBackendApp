namespace ERPBackend.Settings.Application.DocumentTypes.Features.Register.UseCases;

internal sealed class RegisterDocumentTypeInteractor(
    IRegisterDocumentTypeRepository repository,
    IUnitOfWork unitOfWork,
    IRegisterDocumentTypeOutputPort presenter,
    IModelValidatorHub<RegisterDocumentTypePayloadDto> registerDocumentTypeValidator)
    : IRegisterDocumentTypeInputPort
{
    public async Task HandleAsync(RegisterDocumentTypePayloadDto payload)
    {
        Result<DocumentType, IEnumerable<ValidationError>> result;

        if (await registerDocumentTypeValidator.Validate(payload))
        {
            var documentType = DocumentType.Create(payload.Name, payload.Code, payload.Description);

            repository.Handle(documentType);

            await unitOfWork.SaveChangesAsync();

            result = new Result<DocumentType, IEnumerable<ValidationError>>(documentType);
        }
        else
        {
            result = new Result<DocumentType, IEnumerable<ValidationError>>(registerDocumentTypeValidator.Errors);
        }

        presenter.Handle(result);
    }
}