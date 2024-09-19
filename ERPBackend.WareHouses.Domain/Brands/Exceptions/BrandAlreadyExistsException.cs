namespace ERPBackend.WareHouses.Domain.Brands.Exceptions;

public sealed class BrandAlreadyExistsException() : DomainException("La marca ya existe");