namespace ERPBackend.WareHouses.Application.Categories.Features.Update.Interfaces;

public interface IUpdateCategoryInputPort
{
    Task HandleAsync(UpdateCategoryPayloadDto payload);
}