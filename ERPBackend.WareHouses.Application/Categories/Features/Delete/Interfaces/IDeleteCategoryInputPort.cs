namespace ERPBackend.WareHouses.Application.Categories.Features.Delete.Interfaces;

public interface IDeleteCategoryInputPort
{
    Task HandleAsync(Guid id);
}