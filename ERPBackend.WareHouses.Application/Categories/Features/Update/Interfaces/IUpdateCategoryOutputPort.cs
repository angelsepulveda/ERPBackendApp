namespace ERPBackend.WareHouses.Application.Categories.Features.Update.Interfaces;

public interface IUpdateCategoryOutputPort
{
    UpdateCategoryResponseDto Response { get; }
    
    void Handle(Category category);
}