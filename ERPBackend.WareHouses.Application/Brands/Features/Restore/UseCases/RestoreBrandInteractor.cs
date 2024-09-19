using ERPBackend.WareHouses.Application.Brands.Features.Restore.Interfaces;

namespace ERPBackend.WareHouses.Application.Brands.Features.Restore.UseCases;

internal sealed class RestoreBrandInteractor(
    IUpdateBrandRepository updateRepository,
    IGetByIdBrandRepository getByIdRwepository,
    IWareHouseUnitOfWork unitOfWork) : IRestoreBrandInputPort
{
    public async Task HandleAsync(Guid id)
    {
        var brand = await getByIdRwepository.HandleAsync(new BrandId(id));

        if (brand is null) throw new BrandNotFoundException();
        
        brand.Restore();
        
        updateRepository.Handle(brand);
        
        await unitOfWork.SaveChangesAsync();
    }
}