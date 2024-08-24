namespace ERPBackend.Settings.Domain.DocumentTypes.Exceptions;

public sealed class DocumentTypeNotFoundException() : DomainException("El tipo de documento no existe");