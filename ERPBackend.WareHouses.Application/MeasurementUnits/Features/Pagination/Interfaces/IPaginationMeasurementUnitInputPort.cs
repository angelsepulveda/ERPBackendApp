namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Pagination.Interfaces;

public interface IPaginationMeasurementUnitInputPort
{
    Task HandleAsync(PaginationMeasurementUnitPayloadDto payloadDto);
}