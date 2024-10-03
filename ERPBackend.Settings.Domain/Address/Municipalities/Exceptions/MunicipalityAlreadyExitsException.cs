namespace ERPBackend.Settings.Domain.Address.Municipalities.Exceptions;

public sealed class MunicipalityAlreadyExitsException() : DomainException("El comuna ya se encuentra registrada");