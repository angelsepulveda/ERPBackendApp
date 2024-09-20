namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Register.Validators;

public class RegisterMeasurementUnitValidator: AbstractModelValidator<RegisterMeasurementUnitPayloadDto>
{
    public RegisterMeasurementUnitValidator(IValidationService<RegisterMeasurementUnitPayloadDto> validationService) : base(
        validationService)
    {
        AddRuleFor(x => x.Name).NotEmpty("El nombre es requerido")
            .MaximumLength(50, "El nombre no debe superar los 50 caracteres");

        AddRuleFor(x => x.Prefix)
            .MaximumLength(6, "La descripción no debe superar los 6 caracteres");
        
        AddRuleFor(x => x.Description)
            .MaximumLength(256, "La descripción no debe superar los 256 caracteres");
    }
}