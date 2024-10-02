namespace ERPBackend.Settings.Domain.Address.Regions.Services;

internal sealed class ExistByCodeRegionValidationService(IGetByCodeCountryRepository repository)
    : IExistByCodeRegionValidationService
{
    public async Task HandleAsync(Region region)
    {
        if (region.Code is not null)
        {
            var regionExist = await repository.HandleAsync(region.Code);

            if (regionExist is not null && region.Id.Value != regionExist.Id.Value)
                throw new RegionAlreadyExitsException();
        }
      
    }
}