namespace ERPBackend.WareHouses.Application.Categories.Features.Get.Interfaces;

public interface IGetCategoryOutputPort
{
    IReadOnlyList<GetCategoryResponseDto> Response { get; }

    void Handle(IReadOnlyList<Category> categories);
}