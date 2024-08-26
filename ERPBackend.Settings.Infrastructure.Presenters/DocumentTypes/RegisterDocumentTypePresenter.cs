namespace ERPBackend.Settings.Infrastructure.Presenters.DocumentTypes;

internal sealed class RegisterDocumentTypePresenter : IRegisterDocumentTypeOutputPort
{
    public IResult Result { get; private set; }

    public void Handle(Result<DocumentType, IEnumerable<ValidationError>> result)
    {
        result.HandleResult((documentType) => Result = Results.Ok(documentType.Id.Value),
            (errors) => Result = Results.BadRequest(errors.ToProblemDetails(
                "Error en los datos de entrada",
                "Se encontraron uno o mas errores de validación",
                nameof(RegisterDocumentTypePresenter)
            ))
        );
    }
}