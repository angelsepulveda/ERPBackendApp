namespace ERPBackend.WareHouses.Infrastructure.Presenters.Categories;

internal sealed class UpdateCategoryPresenter : IUpdateCategoryOutputPort
{
    public UpdateCategoryResponseDto Response { get; private set; }
    public void Handle(Category category)
    {
        Response = new UpdateCategoryResponseDto(category.Id.Value, category.Name, category.Description);
    }
}