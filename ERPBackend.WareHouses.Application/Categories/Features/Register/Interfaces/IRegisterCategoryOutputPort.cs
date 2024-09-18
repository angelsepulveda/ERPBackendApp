namespace ERPBackend.WareHouses.Application.Categories.Features.Register.Interfaces;

public interface IRegisterCategoryOutputPort
{
    Guid CategoryId { get; }
    void Handle(Category category);
}