namespace ERPBackend.WareHouses.Application.Categories.Features.Register.Interfaces;

public interface IRegisterCategoryInputPort
{
    Task HandleAsync(RegisterCategoryPayloadDto payload);
}