namespace ERPBackend.WareHouses.Infrastructure.Presenters.Categories;

internal sealed class PaginationCategoryPresenter : IPaginationCategoryOutputPort
{
    public PaginationCategoryResponseDto ResponseDto { get; private set; }
    public void Handle(PaginatedList<Category> paginatedCategories)
    {
        var dtos = paginatedCategories.Items
            .Select(x => new CategoryDto(Id: x.Id.Value, Name: x.Name, Description: x.Description,
                Status: x.Status)).ToList();

        ResponseDto  = new PaginationCategoryResponseDto(Data: dtos,
            PageIndex: paginatedCategories.PageIndex, TotalPages: paginatedCategories.TotalPages,
            HasPreviousPage: paginatedCategories.HasPreviousPage, HasNextPage: paginatedCategories.HasNextPage);
    }
}