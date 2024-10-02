namespace ERPBackend.Settings.Application.Address.Regions.Features.Pagination.Interfaces;

public interface IPaginationRegionInputPort
{
    Task HandleAsync(PaginationRegionPayloadDto payload);
}