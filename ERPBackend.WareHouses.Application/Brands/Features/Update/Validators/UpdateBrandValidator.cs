namespace ERPBackend.WareHouses.Application.Brands.Features.Update.Validators;

public class UpdateBrandValidator: AbstractModelValidator<UpdateBrandPayloadDto>
{
    public UpdateBrandValidator(IValidationService<UpdateBrandPayloadDto> validationService) : base(
        validationService)
    {
        AddRuleFor(x => x.Id).NotEmpty("El identificador es requerido");
        
        AddRuleFor(x => x.Name).NotEmpty("El nombre es requerido")
            .MaximumLength(50, "El nombre no debe superar los 20 caracteres");

        AddRuleFor(x => x.Description)
            .MaximumLength(256, "La descripción no debe superar los 256 caracteres");
    }
}