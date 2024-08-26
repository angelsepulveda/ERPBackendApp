namespace ERPBackend.SharedKernel.Validations.Domain.Interfaces;

public interface ICollectionValidationRules<T, TProperty>
{
    ICollectionValidationRules<T, TProperty> SetValidator(IModelValidator<TProperty> validator);
}