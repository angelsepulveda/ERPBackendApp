namespace ERPBackend.WareHouses.Application.Brands.Features.Delete.UseCases;

internal sealed class DeleteBrandInteractor(  
    IUpdateBrandRepository updateRepository,
    IGetByIdBrandRepository getByIdRwepository,
    IWareHouseUnitOfWork unitOfWork) : IDeleteBrandInputPort
{
    public async Task HandleAsync(Guid id)
    {
        var brand = await getByIdRwepository.HandleAsync(new BrandId(id));

        if (brand is null) throw new BrandNotFoundException();
        
        brand.Delete();
        
        updateRepository.Handle(brand);
        
        await unitOfWork.SaveChangesAsync();
    }
}