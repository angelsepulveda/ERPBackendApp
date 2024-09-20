namespace ERPBackend.WareHouses.Domain.MeasurementUnits.Entities;

public sealed class MeasurementUnit : BaseEntity<MeasurementUnitId>
{
    public string Name { get; private set; }
    public string? Prefix { get; private set; }
    public string? Description { get; private set; }
    public bool Status { get; private set; }

    private MeasurementUnit(MeasurementUnitId id, string name, string? prefix, string? description, bool status)
    {
        Id = id;
        Name = name;
        Prefix = prefix;
        Description = description;
        Status = status;
    }

    public static MeasurementUnit Create(string name, string? prefix, string? description)
    {
        var id = new MeasurementUnitId(Guid.NewGuid());
        return new MeasurementUnit(id, name, prefix, description, true);
    }

    public void Update(string name, string? prefix, string? description)
    {
        Name = name;
        Prefix = prefix;
        Description = description;
    }

    public void Delete()
    {
        Status = false;
    }

    public void Restore()
    {
        Status = true;
    }
}