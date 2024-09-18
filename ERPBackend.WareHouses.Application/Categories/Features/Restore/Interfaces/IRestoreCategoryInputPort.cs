namespace ERPBackend.WareHouses.Application.Categories.Features.Restore.Interfaces;

public interface IRestoreCategoryInputPort
{
    Task HandleAsync(Guid id);
}