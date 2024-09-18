namespace ERPBackend.WareHouses.Infrastructure.Presenters.Categories;

internal sealed class RegisterCategoryPresenter : IRegisterCategoryOutputPort
{
    public Guid CategoryId { get; private set; }
    public void Handle(Category category)
    {
        CategoryId = category.Id.Value;
    }
}