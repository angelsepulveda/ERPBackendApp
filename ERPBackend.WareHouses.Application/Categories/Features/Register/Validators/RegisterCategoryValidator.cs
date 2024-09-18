namespace ERPBackend.WareHouses.Application.Categories.Features.Register.Validators;

public class RegisterCategoryValidator: AbstractModelValidator<RegisterCategoryPayloadDto>
{
    public RegisterCategoryValidator(IValidationService<RegisterCategoryPayloadDto> validationService) : base(
        validationService)
    {
        AddRuleFor(x => x.Name).NotEmpty("El nombre es requerido")
            .MaximumLength(50, "El nombre no debe superar los 20 caracteres");

        AddRuleFor(x => x.Description)
            .MaximumLength(256, "La descripción no debe superar los 256 caracteres");
    }
}