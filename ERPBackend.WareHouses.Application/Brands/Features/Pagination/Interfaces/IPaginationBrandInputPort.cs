namespace ERPBackend.WareHouses.Application.Brands.Features.Pagination.Interfaces;

public interface IPaginationBrandInputPort
{
    Task HandleAsync(PaginationBrandPayloadDto payloadDto);
}