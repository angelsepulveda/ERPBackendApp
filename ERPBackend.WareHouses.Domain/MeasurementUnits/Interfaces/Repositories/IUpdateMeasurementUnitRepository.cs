namespace ERPBackend.WareHouses.Domain.MeasurementUnits.Interfaces.Repositories;

public interface IUpdateMeasurementUnitRepository
{
    void Handle(MeasurementUnit measurementUnit);
}