namespace ERPBackend.WareHouses.Infrastructure.Presenters.MeasurementUnits;

internal sealed class PaginationMeasurementUnitPresenter : IPaginationMeasurementUnitOutputPort
{
    public PaginationMeasurementUnitResponseDto Response { get; private set; }

    public void Handle(PaginatedList<MeasurementUnit> paginatedMeasureUnits)
    {
        var dtos = paginatedMeasureUnits.Items
            .Select(x => new MeasurementUnitDto(Id: x.Id.Value, Name: x.Name, Prefix: x.Prefix,
                Description: x.Description,
                Status: x.Status)).ToList();

        Response = new PaginationMeasurementUnitResponseDto(Data: dtos,
            PageIndex: paginatedMeasureUnits.PageIndex, TotalPages: paginatedMeasureUnits.TotalPages,
            HasPreviousPage: paginatedMeasureUnits.HasPreviousPage, HasNextPage: paginatedMeasureUnits.HasNextPage);
    }
}