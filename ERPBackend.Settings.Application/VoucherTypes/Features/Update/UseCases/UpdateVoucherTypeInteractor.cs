namespace ERPBackend.Settings.Application.VoucherTypes.Features.Update.UseCases;

internal sealed class UpdateVoucherTypeInteractor(
    IUpdateVoucherTypeRepository updateRepository,
    IUnitOfWork unitOfWork,
    IGetByIdVoucherTypeRepository getByIdRepository,
    IUpdateVoucherTypeOutputPort presenter,
    IModelValidatorHub<UpdateVoucherTypePayloadDto> updateVoucherTypeValidator) : IUpdateVoucherTypeInputPort
{
    public async Task HandleAsync(UpdateVoucherTypePayloadDto payload)
    {
        if (!await updateVoucherTypeValidator.Validate(payload))
            throw new ValidationException(updateVoucherTypeValidator.Errors);
        
        var voucherType = await getByIdRepository.HandleAsync(new VoucherTypeId(payload.Id));

        if (voucherType is null) throw new VoucherTypeNotFoundException();
        
        voucherType.Update(payload.Name, payload.Code, payload.Description);
        
        updateRepository.Handle(voucherType);

        await unitOfWork.SaveChangesAsync();

        presenter.Handle(voucherType);
    }
}