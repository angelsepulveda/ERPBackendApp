using ERPBackend.SharedKernel.Validations.Domain.Enums;
using ERPBackend.SharedKernel.Validations.Domain.ValueObjects;

namespace ERPBackend.SharedKernel.Validations.Domain.Interfaces;

public interface IModelValidator<T>
{
    Task<bool> ValidateAsync(T model);
    IEnumerable<ValidationError> Errors { get; }
    ValidationConstraint Constraint { get; }
}