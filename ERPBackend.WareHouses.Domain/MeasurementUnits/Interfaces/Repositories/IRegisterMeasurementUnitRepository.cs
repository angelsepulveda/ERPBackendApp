namespace ERPBackend.WareHouses.Domain.MeasurementUnits.Interfaces.Repositories;

public interface IRegisterMeasurementUnitRepository
{
    void Handle(MeasurementUnit measurementUnit);
}