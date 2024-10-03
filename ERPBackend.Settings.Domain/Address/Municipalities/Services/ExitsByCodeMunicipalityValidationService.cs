namespace ERPBackend.Settings.Domain.Address.Municipalities.Services;

internal sealed class ExitsByCodeMunicipalityValidationService(IGetByCodeMunicipalityRepository repository)
    : IExitsByCodeMunicipalityValidationService
{
    public async Task HandleAsync(Municipality municipality)
    {
        if (municipality.Code is not null)
        {
            var municipalityExist = await repository.HandleAsync(municipality.Code);

            if (municipalityExist is not null && municipalityExist.Id.Value != municipality.Id.Value)
                throw new MunicipalityAlreadyExitsException();
        }
    }
}