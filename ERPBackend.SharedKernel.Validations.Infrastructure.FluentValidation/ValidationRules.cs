namespace ERPBackend.SharedKernel.Validations.Infrastructure.FluentValidation;

internal class ValidationRules<T, TProperty>(IRuleBuilderInitial<T, TProperty> ruleBuilderInitial)
    : IValidationRules<T, TProperty>
{
    private IRuleBuilder<T, string> StringRuleBuilder => (IRuleBuilder<T, string>)ruleBuilderInitial;
    private IValidationRules<T, string> ThisAsStringValidationRules => (IValidationRules<T, string>)this;

    public IValidationRules<T, TProperty> NotEmpty(string errorMesssage)
    {
        ruleBuilderInitial.NotEmpty().WithMessage(errorMesssage);

        return this;
    }

    public IValidationRules<T, TProperty> NotNull(string errorMessage)
    {
        ruleBuilderInitial.NotNull().WithMessage(errorMessage);

        return this;
    }

    public IValidationRules<T, TProperty> Nust(Func<TProperty, bool> predicate, string errorMessage)
    {
        ruleBuilderInitial.Must(predicate).WithMessage(errorMessage);

        return this;
    }

    public IValidationRules<T, TProperty> StopOnFirtstFailure(string errorMessage)
    {
        ruleBuilderInitial.Cascade(CascadeMode.Stop);
        return this;
    }

    public IValidationRules<T, TProperty> GreaterThan<TValue>(TValue valueToCompare, string errorMessage)
        where TValue : TProperty, IComparable<TValue>, IComparable
    {
        var builder = (IRuleBuilder<T, TValue>)ruleBuilderInitial;
        
        builder.GreaterThan(valueToCompare).WithMessage(errorMessage);
        
        return this;
    }

    public IValidationRules<T, TProperty> Equal(Expression<Func<T, TProperty>> expression, string errorMessage)
    {
        ruleBuilderInitial.Equal(expression).WithMessage(errorMessage);
        
        return this;
    }

    public IValidationRules<T, string> Length(int length, string errorMessage)
    {
        StringRuleBuilder.Length(length).WithMessage(errorMessage);

        return ThisAsStringValidationRules;
    }

    public IValidationRules<T, string> MaximumLength(int length, string errorMessage)
    {
        StringRuleBuilder.MaximumLength(length).WithMessage(errorMessage);
        
        return ThisAsStringValidationRules;
    }

    public IValidationRules<T, string> MinimumLength(int length, string errorMessage)
    {
        StringRuleBuilder.MinimumLength(length).WithMessage(errorMessage);
        
        return ThisAsStringValidationRules;
    }

    public IValidationRules<T, string> EmailAddress(string errorMessage)
    {
        StringRuleBuilder.EmailAddress().WithMessage(errorMessage);
        
        return ThisAsStringValidationRules;
    }

    public IValidationRules<T, string> Match(string regularExpression, string errorMessage)
    {
        StringRuleBuilder.Matches(regularExpression).WithMessage(errorMessage);
        
        return ThisAsStringValidationRules;
    }
}