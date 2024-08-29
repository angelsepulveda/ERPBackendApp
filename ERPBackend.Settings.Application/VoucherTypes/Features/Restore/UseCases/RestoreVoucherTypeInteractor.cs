namespace ERPBackend.Settings.Application.VoucherTypes.Features.Restore.UseCases;

internal sealed class RestoreVoucherTypeInteractor(
    IUpdateVoucherTypeRepository updateRepository,
    IGetByIdVoucherTypeRepository getByIdRepository,
    IUnitOfWork unitOfWork) : IRestoreVoucherTypeInputPort
{
    public async Task HandleAsync(Guid id)
    {
        var voucherType = await getByIdRepository.HandleAsync(new VoucherTypeId(id));

        if (voucherType is null) throw new VoucherTypeNotFoundException();
        
        voucherType.Restore();
        
        updateRepository.Handle(voucherType);
        
        await unitOfWork.SaveChangesAsync();
    }
}