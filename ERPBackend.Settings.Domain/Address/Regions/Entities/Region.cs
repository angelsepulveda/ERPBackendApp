namespace ERPBackend.Settings.Domain.Address.Regions.Entities;

public class Region : BaseEntity<RegionId>
{
    public CountryId CountryId { get; private set; }
    public string Name { get; private set; }
    public string? Code { get; private set; }
    public bool Status { get; private set; }

    public virtual Country Country { get; set; }

    private Region(RegionId id, CountryId countryId, string name, string? code, bool status)
    {
        Id = id;
        CountryId = countryId;
        Name = name;
        Code = code;
        Status = status;
    }

    public static Region Create(CountryId countryId, string name, string? code)
    {
        return new Region(new RegionId(Guid.NewGuid()), countryId, name, code, true);
    }

    public void Update(CountryId countryId, string name, string? code)
    {
        CountryId = countryId;
        Name = name;
        Code = code;
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