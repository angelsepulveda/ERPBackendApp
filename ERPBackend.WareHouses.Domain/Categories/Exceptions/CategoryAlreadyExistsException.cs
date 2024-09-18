namespace ERPBackend.WareHouses.Domain.Categories.Exceptions;

public sealed class CategoryAlreadyExistsException() : DomainException("Category already exists");