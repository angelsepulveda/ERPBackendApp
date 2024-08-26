namespace ERPBackend.SharedKernel.Validations.Domain.Services;

internal sealed class ModelValidatorHub<ModelType>(IEnumerable<IModelValidator<ModelType>> validators)
    : IModelValidatorHub<ModelType>
{
    public IEnumerable<ValidationError> Errors { get; private set; }

    public async Task<bool> Validate(ModelType model)
    {
        List<ValidationError> currentErrors = [];

        var validatorsFilters =
            validators.Where(v => v.Constraint == ValidationConstraint.AlwaysValidate).ToList();

        validatorsFilters.AddRange(validators.Where(v =>
            v.Constraint == ValidationConstraint.ValidateIfThereAreNoPreviousErrors));

        foreach (var validator in validatorsFilters)
        {
            if ((validator.Constraint != ValidationConstraint.AlwaysValidate) && currentErrors.Count != 0) continue;
            
            if (!await validator.ValidateAsync(model))
            {
                currentErrors.AddRange(validator.Errors);
            }
        }
        
        Errors = currentErrors;
        
        return !Errors.Any();
    }
}