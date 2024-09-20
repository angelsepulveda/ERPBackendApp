namespace ERPBackend.WareHouses.Domain.MeasurementUnits.Exceptions;

public sealed class MeasurementUnitAlreadyExistsException() : DomainException("La unidad de medida ya se encuentra registrada");