namespace ERPBackend.WareHouses.Application.Categories.Features.Update.Validators;

public class UpdateCategoryValidator: AbstractModelValidator<UpdateCategoryPayloadDto>
{
    public UpdateCategoryValidator(IValidationService<UpdateCategoryPayloadDto> validationService) : base(
        validationService)
    {
        AddRuleFor(x => x.Id).NotEmpty("El identificador es requerido");
        
        AddRuleFor(x => x.Name).NotEmpty("El nombre es requerido")
            .MaximumLength(50, "El nombre no debe superar los 20 caracteres");

        AddRuleFor(x => x.Description)
            .MaximumLength(256, "La descripción no debe superar los 256 caracteres");
    }
}