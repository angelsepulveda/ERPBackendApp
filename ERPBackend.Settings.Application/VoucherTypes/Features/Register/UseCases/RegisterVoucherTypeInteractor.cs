namespace ERPBackend.Settings.Application.VoucherTypes.Features.Register.UseCases;

internal sealed class RegisterVoucherTypeInteractor(
    IRegisterVoucherTypeRepository repository,
    IUnitOfWork unitOfWork,
    IRegisterVoucherTypeOutputPort presenter,
    IModelValidatorHub<RegisterVoucherTypePayloadDto> registerVoucherTypeValidator) : IRegisterVoucherTypeInputPort
{
    public async Task HandleAsync(RegisterVoucherTypePayloadDto payload)
    {
        if (!await registerVoucherTypeValidator.Validate(payload))
            throw new ValidationException(registerVoucherTypeValidator.Errors);

        var voucherType = VoucherType.Create(payload.Name, payload.Code, payload.Description);

        repository.Handle(voucherType);

        await unitOfWork.SaveChangesAsync();

        presenter.Handle(voucherType);
    }
}