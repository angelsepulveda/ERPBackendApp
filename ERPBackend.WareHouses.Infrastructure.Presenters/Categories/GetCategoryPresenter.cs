namespace ERPBackend.WareHouses.Infrastructure.Presenters.Categories;

internal sealed class GetCategoryPresenter : IGetCategoryOutputPort
{
    public IReadOnlyList<GetCategoryResponseDto> Response { get; private set; }
    public void Handle(IReadOnlyList<Category> categories)
    {
        Response = categories.Select(c => new GetCategoryResponseDto(c.Id.Value, c.Name)).ToList();
    }
}