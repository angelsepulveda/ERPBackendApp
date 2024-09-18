namespace ERPBackend.WareHouses.Application.Categories.Features.Pagination.Interfaces;

public interface IPaginationCategoryInputPort
{
    Task HandleAsync(PaginationCategoryPayloadDto payloadDto);
}