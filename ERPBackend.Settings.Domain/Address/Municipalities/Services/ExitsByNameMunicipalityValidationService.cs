namespace ERPBackend.Settings.Domain.Address.Municipalities.Services;

internal sealed class ExitsByNameMunicipalityValidationService(IGetByNameMunicipalityRepository repository)
    : IExitsByNameMunicipalityValidationService
{
    public async Task HandleAsync(Municipality municipality)
    {
        var municipalityExist = await repository.HandleAsync(municipality.Name);

        if (municipalityExist is not null && municipality.Id.Value != municipalityExist.Id.Value)
            throw new MunicipalityAlreadyExitsException();
    }
}