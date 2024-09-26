namespace ERPBackend.Settings.Domain.Address.Countries.Exceptions;

public sealed class CountryAlreadyExistsException() : DomainException("El país ya se encuentra registrado");
