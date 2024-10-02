namespace ERPBackend.Settings.Domain.Address.Regions.Exceptions;

public sealed class RegionAlreadyExitsCountryException() : DomainException("La región ya se encuentra registrada en el país");