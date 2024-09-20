namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Update.Validators;

public class UpdateMeasurementUnitValidator: AbstractModelValidator<UpdateMeasurementUnitPayloadDto>
{
    public UpdateMeasurementUnitValidator(IValidationService<UpdateMeasurementUnitPayloadDto> validationService) : base(
        validationService)
    {
        AddRuleFor(x => x.Id).NotEmpty("El identificador es requerido");
        
        AddRuleFor(x => x.Name).NotEmpty("El nombre es requerido")
            .MaximumLength(50, "El nombre no debe superar los 50 caracteres");
        
        AddRuleFor(x => x.Prefix)
            .MaximumLength(6, "La descripción no debe superar los 6 caracteres");

        AddRuleFor(x => x.Description)
            .MaximumLength(256, "La descripción no debe superar los 256 caracteres");
    }
}