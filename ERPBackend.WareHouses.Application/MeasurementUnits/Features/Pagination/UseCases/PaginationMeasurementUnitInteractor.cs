namespace ERPBackend.WareHouses.Application.MeasurementUnits.Features.Pagination.UseCases;

internal sealed class PaginationMeasurementUnitInteractor(IPaginationMeasurementUnitRepository repository,
    IPaginationMeasurementUnitOutputPort presenter) : IPaginationMeasurementUnitInputPort
{
    public async Task HandleAsync(PaginationMeasurementUnitPayloadDto payloadDto)
    {
        var paginatedMeasurementUnits =
            await repository.HandleAsync(payloadDto.PageIndex, payloadDto.PageSize, payloadDto.Search);

        presenter.Handle(paginatedMeasurementUnits);
    }
}