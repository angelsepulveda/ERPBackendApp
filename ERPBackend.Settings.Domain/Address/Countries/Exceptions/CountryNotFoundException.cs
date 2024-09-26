namespace ERPBackend.Settings.Domain.Address.Countries.Exceptions;

public sealed class CountryNotFoundException() : DomainException("El país no se encuentra registrado");
