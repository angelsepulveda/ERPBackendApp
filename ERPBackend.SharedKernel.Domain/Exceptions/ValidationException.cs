using ERPBackend.SharedKernel.Validations.Domain.ValueObjects;

namespace ERPBackend.SharedKernel.Domain.Exceptions;

public class ValidationException : DomainException
{
    public IEnumerable<ValidationError> ValidationErrors { get; private set; }

    public ValidationException(IEnumerable<ValidationError> validationErrors) : base(
        "Ocurrio un o varios errores de validación.")
    {
        ValidationErrors = validationErrors;
    }
}