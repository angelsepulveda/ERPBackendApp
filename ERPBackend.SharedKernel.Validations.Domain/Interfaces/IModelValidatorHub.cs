namespace ERPBackend.SharedKernel.Validations.Domain.Interfaces;

public interface IModelValidatorHub<T>
{
    Task<bool> Validate(T model);
    IEnumerable<ValidationError> Errors { get; }
}
