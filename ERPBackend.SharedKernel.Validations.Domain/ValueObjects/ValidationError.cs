namespace ERPBackend.SharedKernel.Validations.Domain.ValueObjects;

public class ValidationError(string propertyName, string message)
{
    public string PropertyName => propertyName;
    public string Message => message;
}