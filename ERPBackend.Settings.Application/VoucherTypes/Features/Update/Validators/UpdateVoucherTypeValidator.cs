﻿namespace ERPBackend.Settings.Application.VoucherTypes.Features.Update.Validators;

public class UpdateVoucherTypeValidator : AbstractModelValidator<UpdateVoucherTypePayloadDto>
{
    public UpdateVoucherTypeValidator(IValidationService<UpdateVoucherTypePayloadDto> validationService) : base(
        validationService)
    {
        AddRuleFor(x => x.Id).NotEmpty("El identificador es requerido");

        AddRuleFor(x => x.Name).NotEmpty("El nombre es requerido")
            .MaximumLength(20, "El nombre no debe superar los 20 caracteres");

        AddRuleFor(x => x.Code)
            .MaximumLength(10, "El código no debe superar los 10 caracteres");

        AddRuleFor(x => x.Description)
            .MaximumLength(256, "La descripción no debe superar los 256 caracteres");
    }
}