using ERPBackend.SharedKernel.Domain.Exceptions;

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
        if (!await registerDocumentTypeValidator.Validate(payload))
            throw new ValidationException(registerDocumentTypeValidator.Errors);
        
        var documentType = DocumentType.Create(payload.Name, payload.Code, payload.Description);

        repository.Handle(documentType);

        await unitOfWork.SaveChangesAsync();

        presenter.Handle(documentType);
    }
}