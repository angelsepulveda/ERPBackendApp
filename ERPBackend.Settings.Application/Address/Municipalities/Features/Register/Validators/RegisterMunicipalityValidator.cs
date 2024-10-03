namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Register.Validators;

public class RegisterMunicipalityValidator : AbstractModelValidator<RegisterMunicipalityPayloadDto>
{
    public RegisterMunicipalityValidator(IValidationService<RegisterMunicipalityPayloadDto> validationService) : base(
        validationService)
    {
        AddRuleFor(x => x.Name).NotEmpty("El nombre es requerido")
            .MaximumLength(150, "El nombre no debe superar los 150 caracteres");

        AddRuleFor(x => x.CountryId).NotNull("Debe seleccionar un país");

        AddRuleFor(x => x.RegionId).NotNull("Debe seleccionar una región");

        AddRuleFor(x => x.Code)
            .MaximumLength(10, "El código no debe superar los 10 caracteres");
    }
}