namespace ERPBackend.SharedKernel.Validations.Infrastructure.FluentValidation;

internal class CollectionValidationRules<T, TProperty>(
    IRuleBuilderInitialCollection<T, TProperty> ruleBuilderInitialCollection) : ICollectionValidationRules<T, TProperty>
{
    public ICollectionValidationRules<T, TProperty> SetValidator(IModelValidator<TProperty> modelValidator)
    {
        var customModelValidator = modelValidator as AbstractModelValidator<TProperty>;

        var validationService = customModelValidator.ValidationService as FluentValidationService<TProperty>;

        ruleBuilderInitialCollection.SetValidator(validationService.Wrapper);

        return this;
    }
}