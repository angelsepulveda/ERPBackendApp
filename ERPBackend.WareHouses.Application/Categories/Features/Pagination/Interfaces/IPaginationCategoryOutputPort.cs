namespace ERPBackend.WareHouses.Application.Categories.Features.Pagination.Interfaces;

public interface IPaginationCategoryOutputPort
{
    PaginationCategoryResponseDto ResponseDto { get; }
    void Handle(PaginatedList<Category> paginatedCategories);
}