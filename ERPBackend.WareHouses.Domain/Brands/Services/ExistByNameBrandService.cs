namespace ERPBackend.WareHouses.Domain.Brands.Services;

internal sealed class ExistByNameBrandService(IGetByNameBrandRepository repository) : IExistByNameBrandService
{
    public async Task HandleAsync(Brand brand)
    {
        var brandExist = await repository.HandleAsync(brand.Name);
        
        if(brandExist is not null && brand.Id.Value != brandExist.Id.Value) 
            throw new BrandAlreadyExistsException();
    }
}