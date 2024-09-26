using ERPBackend.Settings.Application.Address.Countries.Features.Get.Dtos;
using ERPBackend.Settings.Application.Address.Countries.Features.Get.Interfaces;

namespace ERPBackend.Settings.Infrastructure.Presenters.Address.Countries;

internal sealed class GetCountryPresenter : IGetCountryOutputPort
{
    public IReadOnlyList<GetCountryResponseDto> Response { get; private set; }

    public void Handle(IReadOnlyList<Country> country)
    {
        Response = country.Select(x => new GetCountryResponseDto(x.Id.Value, x.Name)).ToList().AsReadOnly();
    }
}