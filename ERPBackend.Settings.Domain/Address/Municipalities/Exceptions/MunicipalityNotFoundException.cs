namespace ERPBackend.Settings.Domain.Address.Municipalities.Exceptions;

public sealed class MunicipalityNotFoundException() : DomainException("La comuna no se encuentra registrada");