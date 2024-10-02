using ERPBackend.Settings.Application.Address.Regions.Features.Get.Dtos;

namespace ERPBackend.Settings.Application.Address.Regions.Features.Get.Interfaces;

public interface IGetRegionOutputPort
{
    IReadOnlyList<GetRegionResponseDto> Response { get; }
    void Handle(IReadOnlyList<Region> regions);
}