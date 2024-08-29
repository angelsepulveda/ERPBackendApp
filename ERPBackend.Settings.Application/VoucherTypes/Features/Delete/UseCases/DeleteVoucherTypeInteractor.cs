namespace ERPBackend.Settings.Application.VoucherTypes.Features.Delete.UseCases;

internal sealed class DeleteVoucherTypeInteractor(
    IUpdateVoucherTypeRepository updateRepository,
    IGetByIdVoucherTypeRepository getByIdRepository,
    IUnitOfWork unitOfWork)
    : IDeleteVoucherTypeInputPort
{
    public async Task HandleAsync(Guid id)
    {
        var voucherType = await getByIdRepository.HandleAsync(new VoucherTypeId(id));

        if (voucherType is null) throw new VoucherTypeNotFoundException();
        
        voucherType.Delete();
        
        updateRepository.Handle(voucherType);
        
        await unitOfWork.SaveChangesAsync();
    }
}