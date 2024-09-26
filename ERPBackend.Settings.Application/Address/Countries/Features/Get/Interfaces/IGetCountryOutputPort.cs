namespace ERPBackend.Settings.Application.Address.Countries.Features.Get.Interfaces;

public interface IGetCountryOutputPort
{
    IReadOnlyList<GetCountryResponseDto> Response { get; }
    void Handle(IReadOnlyList<Country> country);
}