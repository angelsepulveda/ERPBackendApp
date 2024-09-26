namespace ERPBackend.Settings.Application.Address.Countries.Features.Register.Validators;

public class RegisterCountryValidator: AbstractModelValidator<RegisterCountryPayloadDto>
{
    public RegisterCountryValidator(IValidationService<RegisterCountryPayloadDto> validationService) : base(
        validationService)
    {
        AddRuleFor(x => x.Name).NotEmpty("El nombre es requerido")
            .MaximumLength(50, "El nombre no debe superar los 50 caracteres");

        AddRuleFor(x => x.Code)
            .MaximumLength(10, "El código no debe superar los 10 caracteres");
    }
}