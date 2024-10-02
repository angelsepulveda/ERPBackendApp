namespace ERPBackend.Settings.Application.Address.Regions.Features.Register.Validators;

public class RegisterRegionValidator : AbstractModelValidator<RegisterRegionPayloadDto>
{
    public RegisterRegionValidator(IValidationService<RegisterRegionPayloadDto> validationService) : base(
        validationService)
    {
        AddRuleFor(x => x.Name).NotEmpty("El nombre es requerido")
            .MaximumLength(150, "El nombre no debe superar los 150 caracteres");

        AddRuleFor(x => x.CountryId).NotNull("Debe seleccionar un país");

        AddRuleFor(x => x.Code)
            .MaximumLength(10, "El código no debe superar los 10 caracteres");
    }
}