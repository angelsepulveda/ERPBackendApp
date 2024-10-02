namespace ERPBackend.Settings.Domain.Address.Regions.Services;

internal sealed class ExistByNameRegionValidationService(IGetByNameCountryRepository repository)
    : IExistByNameRegionValidationSarvice
{
    public async Task HandleAsync(Region region)
    {
        var regionExist = await repository.HandleAsync(region.Name);

        if (regionExist is not null && region.Id.Value != regionExist.Id.Value)
            throw new RegionAlreadyExitsException();
    }
}