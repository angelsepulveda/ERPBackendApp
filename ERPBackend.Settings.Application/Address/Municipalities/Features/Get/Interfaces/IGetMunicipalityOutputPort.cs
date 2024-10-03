namespace ERPBackend.Settings.Application.Address.Municipalities.Features.Get.Interfaces;

public interface IGetMunicipalityOutputPort
{
    IReadOnlyList<GetMunicipalityResponseDto> Response { get; }
    void Handle(IReadOnlyList<Municipality> municipalities);
}